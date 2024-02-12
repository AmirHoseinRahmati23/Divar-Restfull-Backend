using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Base;

namespace UnitOfWork.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        public bool UserExists(string username, string email);
        public User GetUserByUserName(string username);
        public User GetUserByUserNameOrEmail(string usernameOrEmail);
        public bool RegisterUser(User user);

    }
}
