using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories
{
    public class TheatreRepository : ITheatreRepository
    {
        public readonly DBContext _context;

        public TheatreRepository(DBContext context)
        {
            _context = context;
        }

        public Theatre Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Theatre> GetAll()
        {
            throw new NotImplementedException();
        }

        public Movie GetMovieFromScreen(int screenId)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovieFromScreen(int theatreId, string screenCode)
        {
            throw new NotImplementedException();
        }

        public Screen GetScreen(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Screen> GetScreens()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Seat> GetSeatsInScreen(int screenId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Theatre> GetTheatresByLocation(int locationId)
        {
            throw new NotImplementedException();
        }
    }
}
