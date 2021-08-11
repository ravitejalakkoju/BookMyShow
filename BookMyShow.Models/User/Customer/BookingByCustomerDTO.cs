using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Models.User.Customer
{
    public class BookingByCustomerDTO
    {
        public int ID { get; set; }

        public int Amount { get; set; }

        public DateTime DateTime { get; set; }

        public string Status { get; set; }

        public string CustomerID { get; set; }

        public string Seats { get; set; }

        public string ScreenCode { get; set; }

        public string TheatreName { get; set; }

        public DateTime ShowTime { get; set; }

        public string MovieName { get; set; }

        public string LocationName { get; set; }

        public string MovieAPIID { get; set; }
    }
}
