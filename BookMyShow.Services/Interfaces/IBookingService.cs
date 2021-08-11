using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Models.User.Customer;

namespace BookMyShow.Services.Interfaces
{
    public interface IBookingService
    {
        public BookingByCustomerDTO Get(int bookingId);

        public IEnumerable<BookingByCustomerDTO> GetAllByCustomer(int customerId);

        public Object Create(BookingDTO booking);
    }
}
