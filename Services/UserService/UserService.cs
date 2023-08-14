using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.UserService
{

    
    public class UserService : IUserService
    {
         private static List<User> users = new List<User>
        {
            new User
            {
                Id = Guid.NewGuid(),
                Name = "Gersching",
                Abteilung = "HR",
                Kunden = new List<Customer>
                {
                    new Customer { Id = Guid.NewGuid(), Ansprechpartner = "Deniz Nezic", Firma = "Yallah IT", UserId = Guid.NewGuid() },
                    new Customer { Id = Guid.NewGuid(), Ansprechpartner = "Imad Ali Kkhan", Firma = "Yallah IT", UserId = Guid.NewGuid() },
                     new Customer { Id = Guid.NewGuid(), Ansprechpartner = "Hiwad Azekzei", Firma = "Yallah IT", UserId = Guid.NewGuid() }
                }
            },
            new User
            {
                Id = Guid.NewGuid(),
                Name = "Alice",
                Abteilung = "IT",
                Kunden = new List<Customer>
                {
                    new Customer { Id = Guid.NewGuid(), Ansprechpartner = "Peter", Firma = "123 Ltd", UserId = Guid.NewGuid() }
                }
            },
        
        };
        public List<User> CreateUser(User user)
        {
           users.Add(user);
            return users;
        }

        public List<User> DeleteUser(Guid id, User request)
        {
               var user = users.Find(x=>x.Id == id);
            if(user is null) {
                return null;
            }
           users.Remove(user);
            return users;
        }

        public User GetUser(string name)
        {
              var user = users.Find(x=>x.Name == name);
            if(user is null) {
                return  null;
            }
            return user;
        }

        public List<User> GetUsers()
        {
             return users;
        }

        public List<User> UpdateUser(Guid id, User request)
        {
              var user = users.Find(x=>x.Id == id);
            if(user is null) {
                return null;
            }
            user.Name = request.Name;
            user.Abteilung = request.Abteilung;
            user.Kunden = request.Kunden;
            return users;
          
        }
    }
}