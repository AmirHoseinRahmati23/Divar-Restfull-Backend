using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class UserRegisterViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class UserLoginViewModel
    {
        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
