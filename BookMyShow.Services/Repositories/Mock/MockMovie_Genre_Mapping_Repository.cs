using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;
using BookMyShow.Services.Repositories.Interfaces;
using PetaPoco.NetCore;

namespace BookMyShow.Services.Repositories.Mock
{
    public class MockMovie_Genre_Mapping_Repository : IMovie_Genre_Mapping_Repository
    {
        private readonly DBContext _context;

        public MockMovie_Genre_Mapping_Repository(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie_Genre_Mapping> GetAllByMovieId(int movieId)
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Movie_Genre_Mapping")
                        .Where("MovieID = @0", movieId);

            return _context.Query<Movie_Genre_Mapping>(query);
        }

        public IEnumerable<Movie_Genre_Mapping> GetAllByGenreId(int genreId)
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Movie_Genre_Mapping")
                        .Where("GenreID = @0", genreId);

            return _context.Query<Movie_Genre_Mapping>(query);
        }
    }
}
