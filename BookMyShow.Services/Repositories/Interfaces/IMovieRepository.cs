using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface IMovieRepository: IRepository<Movie>
    {
        public MovieView GetDetails(int movieId);

        public IEnumerable<MovieView> GetAllAtLocation(int locationId);
    }
}
