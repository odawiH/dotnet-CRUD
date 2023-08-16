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
       
            return await _userService.GetUsers();
        }

          [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(Guid id)
        {
           
              var result = await _userService.GetUser(id);
           if(result is null) {
                return NotFound("User not found");
           }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> CreateUser(User user)
        {
       
           var result = await _userService.CreateUser(user);
            return Ok(result);
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult<List<User>>> UpdateUser(Guid id, User request)
        {
            // await Task.Delay(500); // Simuliert eine asynchrone Aufgabe (z. B. Datenbankabfrage).
            var result = await _userService.UpdateUser(id, request);
           if(result is null) {
                return NotFound("User not found");
           }
            return Ok(result);
        }
                
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> DeleteUser(Guid id, User request)
        {
           
           var result = await _userService.DeleteUser(id, request);
           if(result is null) {
                return NotFound("User not found");
           }
            return Ok(result);
        }
        
    }
}