using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        // private readonly ICustomerService _customerService;
        // public CustomerController(ICustomerService customerService)
        // {
        //     _customerService = customerService;
            
        // }

        // [HttpGet]
        // public async Task<ActionResult<List<User>>> GetCustomers()
        // {
       
        //     return await _customerService.GetCustomers();
        // }

        //   [HttpGet("{id}")]
        // public async Task<ActionResult<User>> GetUser(Guid id)
        // {
           
        //       var result = await _customerService.GetUser(id);
        //    if(result is null) {
        //         return NotFound("User not found");
        //    }
        //     return Ok(result);
        // }

        // [HttpPost]
        // public async Task<ActionResult<List<User>>> CreateUser(User user)
        // {
       
        //    var result = await _customerService.CreateUser(user);
        //     return Ok(result);
        // }

        
        // [HttpPut("{id}")]
        // public async Task<ActionResult<List<User>>> UpdateUser(Guid id, User request)
        // {
        //     // await Task.Delay(500); // Simuliert eine asynchrone Aufgabe (z. B. Datenbankabfrage).
        //     var result = await _customerService.UpdateUser(id, request);
        //    if(result is null) {
        //         return NotFound("User not found");
        //    }
        //     return Ok(result);
        // }
                
        // [HttpDelete("{id}")]
        // public async Task<ActionResult<List<User>>> DeleteUser(Guid id, User request)
        // {
           
        //    var result = await _customerService.DeleteUser(id, request);
        //    if(result is null) {
        //         return NotFound("User not found");
        //    }
        //     return Ok(result);
        // }
       



        
    }
}