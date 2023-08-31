using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Services.CustomerService;
using dotnet_rpg.Dtos.CustomerDto;


namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;

        }

        //[HttpGet]
        //public async Task<ActionResult<List<Customer>>> GetCustomers()
        //{

        //    return await _customerService.GetCustomers();
        //}

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(Guid id)
        {

            var result = await _customerService.GetCustomer(id);

            if (result is null)
            {
                return NotFound("User not found");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<GetCustomerDto>>> CreateCustomer(CreateCustomerDto createCustomerDto)
        {

            var result = await _customerService.CreateCustomer(createCustomerDto);
            return Ok(result);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<List<Customer>>> UpdateCustomer(Guid id, UpdateCustomerDto updateCustomerDtorequest)
        {
            // await Task.Delay(500); // Simuliert eine asynchrone Aufgabe (z. B. Datenbankabfrage).
            var result = await _customerService.UpdateCustomer(id, updateCustomerDtorequest);
            if (result is null)
            {
                return NotFound("User not found");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Customer>>> DeleteCustomer(Guid id)
        {

            var result = await _customerService.DeleteCustomer(id);
            if (result is null)
            {
                return NotFound("User not found");
            }
            return Ok(result);
        }





    }
}