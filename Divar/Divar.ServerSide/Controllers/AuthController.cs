using Amazon.Runtime.SharedInterfaces;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Unicode;
using UnitOfWork;
using ViewModels;

namespace Divar.ServerSide.Controllers
{
    public class AuthController : BaseApiControllerWithDatabase
    {
        public IConfiguration Configuration { get; set; }
        public AuthController(IUnitOfWork unitOfWork, IConfiguration configuration) : base(unitOfWork)
        {
            Configuration = configuration;
        }

        [HttpGet("Register")]
        public IActionResult Register(UserRegisterViewModel model)
        {
            if (UnitOfWork.UserRepository.UserExists(model.UserName, model.Email))
            {
                return BadRequest("User Already Exist");
            }
            var user = new User()
            {
                Email = model.Email,
                UserName = model.UserName,
            };

            var hash = new HMACSHA3_512();
            user.PasswordHash = hash.ComputeHash(Encoding.UTF8.GetBytes(model.Password));

            var result = UnitOfWork.UserRepository.RegisterUser(user);
            
            if (!result) return BadRequest("Just Because.....");


            return Ok("Success(Life of your Aunt)!");
        }

        [HttpPost("Login")]
        public IActionResult Login(UserLoginViewModel model)
        {
            if(!UnitOfWork.UserRepository.UserExists(model.UserNameOrEmail, model.UserNameOrEmail))
            {
                return NotFound("Not a User");
            }
            var user = UnitOfWork.UserRepository.GetUserByUserNameOrEmail(model.UserNameOrEmail);

            if (user == null)
            {
                return NotFound();
            }

            var claims = new List<Claim>() 
            { 
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email),
            };


            // Create SecretKey and Signing Credentials
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetSection("SecretJWTKey").Value));
            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            
            // Create Token Options
            var tokenOptions = new JwtSecurityToken
                (
                claims: claims, 
                signingCredentials: signingCredentials, 
                issuer:"Me",
                audience: "You",
                expires: DateTime.Now.AddDays(7)
                );
            
            // Generate Token
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.WriteToken(tokenOptions);
            



            return Ok(token);
        }
    }
}
