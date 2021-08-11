using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Models.Theatre;

namespace BookMyShow.Services.Interfaces
{
    public interface ITheatreService
    {
        public TheatreDTO Get(int theatreId);

        public IEnumerable<TheatreDTO> GetAllForMovieAtLocation(int locationId, int movieId);
    }
}
