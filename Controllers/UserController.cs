using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
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

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            // await Task.Delay(1000); // Simuliert eine asynchrone Aufgabe (z. B. Datenbankabfrage).
            return Ok(users);
        }

          [HttpGet("{name}")]
        public async Task<ActionResult<User>> GetUser(string name)
        {
            // await Task.Delay(1000); // Simuliert eine asynchrone Aufgabe (z. B. Datenbankabfrage).
            var user = users.Find(x=>x.Name == name);
            if(user is null) {
                return NotFound("Sorry aber der User existiert nicht !!");
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> CreateUser(User user)
        {
            // await Task.Delay(1000); // Simuliert eine asynchrone Aufgabe (z. B. Datenbankabfrage).
            users.Add(user);
            return Ok(users);
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdateUser(Guid id, User request)
        {
            // await Task.Delay(1000); // Simuliert eine asynchrone Aufgabe (z. B. Datenbankabfrage).
            var user = users.Find(x=>x.Id == id);
            if(user is null) {
                return NotFound("Sorry aber der User existiert nicht!!");
            }
            user.Name = request.Name;
            user.Abteilung = request.Abteilung;
            user.Kunden = request.Kunden;
            return Ok(user);
        }
                
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(Guid id, User request)
        {
            // await Task.Delay(1000); // Simuliert eine asynchrone Aufgabe (z. B. Datenbankabfrage).
            var user = users.Find(x=>x.Id == id);
            if(user is null) {
                return NotFound("Sorry aber der User existiert nicht!!");
            }
           users.Remove(user);
            return Ok(user);
        }
        
    }
}