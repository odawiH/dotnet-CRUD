using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
            
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            await Task.Delay(500); // Simuliert eine asynchrone Aufgabe (z. B. Datenbankabfrage).
              var result = _userService.GetUsers();
           if(result is null) {
                return NotFound("No Users found");
           }
            return Ok(result);
        }

          [HttpGet("{name}")]
        public async Task<ActionResult<User>> GetUser(string name)
        {
            await Task.Delay(500); // Simuliert eine asynchrone Aufgabe (z. B. Datenbankabfrage).
              var result = _userService.GetUser(name);
           if(result is null) {
                return NotFound("User not found");
           }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> CreateUser(User user)
        {
            await Task.Delay(500); // Simuliert eine asynchrone Aufgabe (z. B. Datenbankabfrage).
           var result = _userService.CreateUser(user);
            return Ok(result);
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult<List<User>>> UpdateUser(Guid id, User request)
        {
            await Task.Delay(500); // Simuliert eine asynchrone Aufgabe (z. B. Datenbankabfrage).
            var result = _userService.UpdateUser(id, request);
           if(result is null) {
                return NotFound("User not found");
           }
            return Ok(result);
        }
                
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> DeleteUser(Guid id, User request)
        {
            await Task.Delay(500); // Simuliert eine asynchrone Aufgabe (z. B. Datenbankabfrage).
           var result = _userService.DeleteUser(id, request);
           if(result is null) {
                return NotFound("User not found");
           }
            return Ok(result);
        }
        
    }
}