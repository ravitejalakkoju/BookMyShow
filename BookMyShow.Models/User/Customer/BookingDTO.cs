using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Models.User.Customer
{
    public class BookingDTO
    {
        public int ID { get; set; }

        public int Amount { get; set; }

        public DateTime DateTime { get; set; }

        public int Status { get; set; }

        public int CustomerID { get; set; }
    }
}
