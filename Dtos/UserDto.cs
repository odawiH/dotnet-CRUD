using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos
{
    public class GetUserDto
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Abteilung { get; set; }
              
    }


     public class CreateUserDto
    {
        public string? Name { get; set; }

        public string? Abteilung { get; set; }
              
    }


}