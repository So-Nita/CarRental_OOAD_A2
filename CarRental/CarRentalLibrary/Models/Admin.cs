using CarRentalLibrary.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalLibrary.Models
{
    public class Admin
    {
        public string Id { get; set; } = "";
        public string UserName { get; set; } = "";
        public string Name { get; set; } = "";
        public string Password { get; set; }= "";
        public RoleType Role { get; set; }
    }
}
