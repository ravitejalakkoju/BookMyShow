using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Services.Repositories.Interfaces;

namespace BookMyShow.Services.Repositories.Mock
{
    public class MockCustomerWrapper: ICustomerWrapper
    {
        private readonly DBContext _context;

        private ICustomerRepository _customerRepository;
        private IBookingRepository _bookingRepository;
        private ITicketRepository _ticketRepository;

        public MockCustomerWrapper(DBContext context)
        {
            _context = context;
        }

        public ICustomerRepository CustomerRepository
        {
            get
            {
                if(_customerRepository == null)
                {
                    _customerRepository = new MockCustomerRepository(_context);
                }
                return _customerRepository;
            }
        }

        public IBookingRepository BookingRepository
        {
            get
            {
                if (_bookingRepository == null)
                {
                    _bookingRepository = new MockBookingRepository(_context);
                }
                return _bookingRepository;
            }
        }

        public ITicketRepository TicketRepository
        {
            get
            {
                if(_ticketRepository == null)
                {
                    _ticketRepository = new MockTicketRepository(_context);
                }
                return _ticketRepository;
            }
        }
    }
}
