using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Models.DTO
{
    public class BookingDTO
    {
        public int ID { get; set; }

        public int Amount { get; set; }

        public DateTime DateTime { get; set; }

        public string Status { get; set; }

        public string PaymentMode { get; set; }

        public string CustomerID { get; set; }

        public List<TicketDTO> Tickets { get; set; }
    }
}
