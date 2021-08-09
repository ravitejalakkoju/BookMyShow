using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Services.Repositories.Interfaces;
using BookMyShow.Entities;
using PetaPoco.NetCore;

namespace BookMyShow.Services.Repositories.Mock
{
    public class MockBookingRepository: IBookingRepository
    {
        private readonly DBContext _context;

        public MockBookingRepository(DBContext context)
        {
            _context = context;
        }

        public BookingByCustomer Get(int bookingId)
        {
            return _context.SingleOrDefault<BookingByCustomer>(bookingId);
        }

        public IEnumerable<BookingByCustomer> GetAllByCustomer(int customerId)
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("BookingByCustomer")
                        .Where("CustomerID = @0", customerId);

            return _context.Query<BookingByCustomer>(query);
        }

        public Object Insert(Booking booking)
        {
            return _context.Insert("Booking", "ID", true, booking);
        }
    }
}
