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
        public BookingByCustomer Get(int bookingId);

        public IEnumerable<BookingByCustomer> GetAllByCustomer(int customerId);

        public Object Insert(Booking booking);
    }
}
