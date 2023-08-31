using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.CustomerDto;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CustomerService

{ 
public class CustomerService : ICustomerService
{

    private readonly DataContext _context;

    public CustomerService(DataContext context)
    {
        _context = context;
    }


    public async Task<GetCustomerDto> CreateCustomer(CreateCustomerDto customerDto)
    {
        //    user.Id = Guid.NewGuid();
        //      foreach (var customer in user.Kunden)
        //         {
        //             customer.Id = Guid.NewGuid();
        //             customer.UserId = user.Id;
        //         }
        var customer = new Customer
        {
            Id = new Guid(),
            Ansprechpartner = customerDto.Ansprechpartner,
            Firma = customerDto.Firma,
            UserId = customerDto.UserId
        };

        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();

        //var user = await _context.Users.FindAsync(customer.UserId);
        //    user.Kunden.Add(customer);

        

        return new GetCustomerDto
        {
            Id = customer.Id,
            Ansprechpartner = customer.Ansprechpartner,
            Firma = customer.Firma,
            UserId= customer.UserId
        };
    }

        public async Task<List<Customer>> DeleteCustomer(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer is null)
            {
                return null;
            }
            _context.Customers.Remove(customer);

            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomer(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer is null)
            {
                return null;
            }
            return customer;
        }

        //public async Task<List<User>> GetUsers()
        //{
        //    var users = await _context.Users.ToListAsync();
        //    return users;
        //}

        public async Task<List<Customer>> UpdateCustomer(Guid id, UpdateCustomerDto updateCustomerDtorequest)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer is null)
            {
                return null;
            }
            customer.Ansprechpartner =  updateCustomerDtorequest.Ansprechpartner;
            customer.Firma = updateCustomerDtorequest.Firma;
            

            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();

        }
    }
}