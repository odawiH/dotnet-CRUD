using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Abteilung { get; set; }

        public List <Customer>? Kunden { get; set; }
        
    }
}