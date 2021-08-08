using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface IBookingRepository
    {
        public Booking Get(int bookingId);

        public IEnumerable<Booking> GetAllByCustomer(int customerId);
    }
}
