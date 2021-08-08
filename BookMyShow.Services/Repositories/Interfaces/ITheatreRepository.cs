using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface ITheatreRepository
    {
        public Theatre Get(int theatreId);

        public IEnumerable<TheatreView> GetAllForMovieAtLocation(int locationId, int movieId);
    }
}
