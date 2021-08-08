using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Services.Repositories.Interfaces;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories.Mock
{
    public class MockBookingRepository: IBookingRepository
    {
        private readonly DBContext _context;

        public MockBookingRepository(DBContext context)
        {
            _context = context;
        }

        public Booking Get(int bookingId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Booking> GetAllByCustomer(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
