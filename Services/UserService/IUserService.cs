using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();

        Task<User> GetUser(Guid id);

        Task<User> CreateUser(User user);

        Task<List<User>> UpdateUser(Guid id, User request);

        Task<List<User>> DeleteUser(Guid id, User request);

        
    }
}