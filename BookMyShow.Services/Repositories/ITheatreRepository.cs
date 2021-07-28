using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories
{
    public interface ITheatreRepository: IQueryRepository<Theatre>
    {
        public IEnumerable<Theatre> GetTheatresByLocation(int locationId);

        public IEnumerable<Screen> GetScreens();

        public Screen GetScreen(int id);

        public IEnumerable<Seat> GetSeatsInScreen(int screenId);

        public Movie GetMovieFromScreen(int screenId);

        public Movie GetMovieFromScreen(int theatreId, string screenCode);
    }
}
