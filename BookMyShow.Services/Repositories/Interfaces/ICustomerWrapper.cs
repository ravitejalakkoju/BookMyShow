using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface ICustomerWrapper
    {
        public ICustomerRepository CustomerRepository { get; }

        public IBookingRepository BookingRepository { get; }

        public ITicketRepository TicketRepository { get; }
    }
}
