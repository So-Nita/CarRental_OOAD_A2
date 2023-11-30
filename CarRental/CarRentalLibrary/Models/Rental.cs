using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalLibrary.Models
{
    public class Rental
    {
        public string Id { get; set; }
        public string UserId { get; set; } = "";
        public string CarId { get; set; } = "";
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalCost {get; set; }
        public string PaymentId { get; set; } = "";
    }
}
