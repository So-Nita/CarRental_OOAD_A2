using CarRentalLibrary.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalLibrary.Models
{
    public class User
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public GenderType Gender { get; set; }  
        public string? Address { get; set; }
        public string Contact { get; set; } = null!;
        public string? Email { get; set; }
        public string Password { get; set; } = null!;
    }
}
