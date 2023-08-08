using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Models
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string? Ansprechpartner { get; set; }

        public string? Firma { get; set; }

        public Guid UserId { get; set; }

        public static implicit operator List<object>(Customer v)
        {
            throw new NotImplementedException();
        }
    }
}