using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  dotnet_rpg.Dtos;

namespace dotnet_rpg.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();

        Task<User> GetUser(Guid id);

        Task<GetUserDto> CreateUser(CreateUserDto userDto);

        Task<List<User>> UpdateUser(Guid id, User request);

        Task<List<User>> DeleteUser(Guid id, User request);

        
    }
}