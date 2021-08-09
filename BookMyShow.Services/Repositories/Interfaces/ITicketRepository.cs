using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface ITicketRepository
    {
        public Ticket Get(int ticketId);

        public IEnumerable<Ticket> GetAllPerBooking(int bookingId);

        public void Insert(Ticket ticket);
    }
}
