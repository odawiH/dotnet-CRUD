using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.CustomerDto
{
    public class GetCustomerDto
    {
        public Guid Id { get; set; }

        public string? Ansprechpartner { get; set; }

        public string? Firma { get; set; }

        public Guid UserId { get; set; }



    }


    public class CreateCustomerDto
    {
        public string? Ansprechpartner { get; set; }

        public string? Firma { get; set; }

        public Guid UserId { get; set; }


    }


    public class UpdateCustomerDto
    {

            public string? Ansprechpartner { get; set; }

            public string? Firma { get; set; }


    }

}