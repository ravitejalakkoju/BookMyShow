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
    public class MockMovie_Language_Mapping_Repository: IMovie_Language_Mapping_Repository
    {
        private readonly DBContext _context;

        public MockMovie_Language_Mapping_Repository(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie_Language_Mapping> GetAllByMovieId(int movieId)
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Movie_Language_Mapping")
                        .Where("MovieID = @0", movieId);

            return _context.Query<Movie_Language_Mapping>(query);
        }

        public IEnumerable<Movie_Language_Mapping> GetAllByLanguageId(int languageId)
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Movie_Language_Mapping")
                        .Where("LanguageID = @0", languageId);

            return _context.Query<Movie_Language_Mapping>(query);
        }
    }
}
