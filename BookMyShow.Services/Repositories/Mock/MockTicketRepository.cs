using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;
using BookMyShow.Services.Repositories.Interfaces;
using PetaPoco.NetCore;

namespace BookMyShow.Services.Repositories.Mock
{
    public class MockTicketRepository : ITicketRepository
    {
        private readonly DBContext _context;

        public MockTicketRepository(DBContext context)
        {
            _context = context;
        }

        public Ticket Get(int ticketId)
        {
            return _context.SingleOrDefault<Ticket>(ticketId);
        }

        public IEnumerable<Ticket> GetAllPerBooking(int bookingId)
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Ticket")
                        .Where("BookingID = @0", bookingId);

            return _context.Query<Ticket>(query);
        }

        public void Insert(Ticket ticket)
        {
            _context.Insert("Ticket", "ID", ticket);
        }
    }
}
