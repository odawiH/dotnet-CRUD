using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  dotnet_rpg.Dtos;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.UserService
{

    
    public class UserService : IUserService
    {
     
        private readonly DataContext _context;

        public UserService(DataContext context){
            _context = context;
        }


        public async Task<GetUserDto> CreateUser(CreateUserDto userDto)
        {
        //    user.Id = Guid.NewGuid();
        //      foreach (var customer in user.Kunden)
        //         {
        //             customer.Id = Guid.NewGuid();
        //             customer.UserId = user.Id;
        //         }
            var user = new User { 
                Id = new Guid(),
                Name = userDto.Name,
                Abteilung = userDto.Abteilung,
                Kunden = new List< Customer >()
            };

           _context.Users.Add(user);
           await _context.SaveChangesAsync();  
             return new GetUserDto { 
                Id = user.Id,
                Name = user.Name,
                Abteilung = user.Abteilung
             };
        }

        public async Task<List<User>> DeleteUser(Guid id, User request)
        {
               var user = await _context.Users.FindAsync(id);
            if(user is null) {
                return null;
            }
           _context.Users.Remove(user);

           await _context.SaveChangesAsync();  

             return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUser(Guid id)
        {
              var user = await _context.Users.FindAsync(id);
            if(user is null) {
                return  null;
            }
            return user;
        }

        public async Task< List<User>> GetUsers()
        {
            var users= await _context.Users.ToListAsync();
             return users;
        }

        public async Task<List<User>> UpdateUser(Guid id, User request)
        {
             var user = await _context.Users.FindAsync(id);
            if(user is null) {
                return null;
            }
            user.Name = request.Name;
            user.Abteilung = request.Abteilung;
            user.Kunden = request.Kunden;

            await _context.SaveChangesAsync();  

            return await _context.Users.ToListAsync();
          
        }
    }
}