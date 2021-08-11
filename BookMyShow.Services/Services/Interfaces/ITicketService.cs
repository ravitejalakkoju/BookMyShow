using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Models.User.Customer;

namespace BookMyShow.Services.Interfaces
{
    public interface ITicketService
    {
        public TicketDTO Get(int ticketId);

        public IEnumerable<TicketDTO> GetAllPerBooking(int bookingId);

        public void Create(TicketDTO ticket);
    }
}
