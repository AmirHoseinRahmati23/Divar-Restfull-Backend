using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Repositories;

namespace UnitOfWork.Services;

public class UserRepository : Repository<User>, IUserRepository
{
    internal UserRepository(DatabaseContext databaseContext) : base(databaseContext)
    {
    }

    public User GetUserByUserNameOrEmail(string usernameOrEmail)
    {
        if(string.IsNullOrWhiteSpace(usernameOrEmail)) 
            throw new ArgumentNullException(nameof(usernameOrEmail));

        var user = DatabaseContext.Users.SingleOrDefault(u => u.UserName == usernameOrEmail || u.Email == usernameOrEmail);


        return user;
    }

    public bool RegisterUser(User user)
    {
        if(user == null)
            throw new ArgumentNullException(nameof(user));
        try
        {

            DatabaseContext.Users.Add(user);
            return true;
        }
        catch
        {
            return false;
        }
    }


    public User GetUserByUserName(string username)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new ArgumentNullException(nameof(username));

        var user = DatabaseContext.Users.SingleOrDefault(u => u.UserName == username);


        return user;
    }


    public bool UserExists(string userName, string email)
    {
        return DatabaseContext.Users.Any(u => u.UserName == userName || u.Email == email);
    }
}
