using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalLibrary.Models
{
    public class Payment
    {
        public string Id { get; set; } = null!;
        public string CardHolder { get; set; } = null!;
        public string CardNumber { get; set; }=null!;
        public DateTime ExpiredDate { get; set; }
    }
}
