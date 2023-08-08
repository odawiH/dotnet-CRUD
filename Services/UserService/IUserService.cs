using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.UserService
{
    public interface IUserService
    {
        List<User> GetUsers();

        User GetUser(string name);

        List<User> CreateUser(User user);

        User UpdateUser(Guid id, User request);

        User DeleteUser(Guid id, User request);

        
    }
}