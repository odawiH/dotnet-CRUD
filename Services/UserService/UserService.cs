using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.UserService
{

    
    public class UserService : IUserService
    {
        //  private static List<User> users = new List<User>
        // {
        //     new User
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "Gersching",
        //         Abteilung = "HR",
        //         Kunden = new List<Customer>
        //         {
        //             new Customer { Id = Guid.NewGuid(), Ansprechpartner = "Deniz Nezic", Firma = "Yallah IT", UserId = Guid.NewGuid() },
        //             new Customer { Id = Guid.NewGuid(), Ansprechpartner = "Imad Ali Kkhan", Firma = "Yallah IT", UserId = Guid.NewGuid() },
        //              new Customer { Id = Guid.NewGuid(), Ansprechpartner = "Hiwad Azekzei", Firma = "Yallah IT", UserId = Guid.NewGuid() }
        //         }
        //     },
        //     new User
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "Alice",
        //         Abteilung = "IT",
        //         Kunden = new List<Customer>
        //         {
        //             new Customer { Id = Guid.NewGuid(), Ansprechpartner = "Peter", Firma = "123 Ltd", UserId = Guid.NewGuid() }
        //         }
        //     },
        
        // };

        private readonly DataContext _context;

        public UserService(DataContext context){
            _context = context;
        }


        public async Task<List<User>> CreateUser(User user)
        {
           
           _context.Users.Add(user);
           await _context.SaveChangesAsync();  
             return await _context.Users.ToListAsync();
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

        public async Task<User> GetUser(string name)
        {
              var user = await _context.Users.FindAsync(name);
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