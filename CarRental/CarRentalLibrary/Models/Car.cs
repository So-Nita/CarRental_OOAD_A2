using CarRentalLibrary.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalLibrary.Models
{
    public class Car
    {
        public string Id { get; set; } = null!;
        public string Model { get; set; }= null!;
        public int Year { get; set; }
        public CarType Type { get; set; }
        public decimal Capacity { get; set; }   
        public decimal PricePerDay { get; set; }    
        public string Color { get; set; } = null!;
        public BrandType Brand { get; set; } = null!;
    }
}
