using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.CustomerDto;

namespace dotnet_rpg.Services.CustomerService
{
    public interface ICustomerService
    {
        //Task<List<User>> GetCustomer();

        Task<Customer> GetCustomer(Guid id);

        Task<GetCustomerDto> CreateCustomer(CreateCustomerDto CustomerDto);

        Task<List<Customer>> UpdateCustomer(Guid id, UpdateCustomerDto updateCustomerDtorequest );

        Task<List<Customer>> DeleteCustomer(Guid id);


    }
}