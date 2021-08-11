using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Models.User.Customer
{
    public class TicketDTO
    {
        public int ID { get; set; }

        public int SeatID { get; set; }

        public int BookingID { get; set; }
    }
}
