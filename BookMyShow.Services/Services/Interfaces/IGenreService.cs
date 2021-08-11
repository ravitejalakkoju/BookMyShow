using System.Collections.Generic;
using BookMyShow.Models.Movie;

namespace BookMyShow.Services.Interfaces
{
    public interface IGenreService
    {
        public GenreDTO Get(int id);

        public IEnumerable<GenreDTO> GetAll();
    }
}
