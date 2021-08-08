using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Services.Repositories.Interfaces;

namespace BookMyShow.Services.Repositories.Mock
{
    public class MockTheatreWrapper : ITheatreWrapper
    {
        private ITheatreRepository theatreRepository;

        private IScreenRepository screenRepository;

        private ISeatRepository seatRepository;

        private readonly DBContext _context;

        public MockTheatreWrapper(DBContext context)
        {
            _context = context;
        }
        public ITheatreRepository TheatreRepository
        {
            get
            {
                if(theatreRepository == null)
                {
                    theatreRepository = new MockTheatreRepository(_context);
                }
                return theatreRepository;
            }
        }

        public IScreenRepository ScreenRepository
        {
            get
            {
                if(screenRepository == null)
                {
                    screenRepository = new MockScreenRepository(_context);
                }
                return screenRepository;
            }
        }

        public ISeatRepository SeatRepository
        {
            get
            {
                if(seatRepository == null)
                {
                    seatRepository = new MockSeatRepository(_context);
                }
                return seatRepository;
            }
        }
    }
}
