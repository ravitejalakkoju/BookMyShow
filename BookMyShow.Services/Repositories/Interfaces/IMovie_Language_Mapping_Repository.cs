using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface IMovie_Language_Mapping_Repository
    {
        public IEnumerable<Movie_Language_Mapping> GetAllByMovieId(int movieId);

        public IEnumerable<Movie_Language_Mapping> GetAllByLanguageId(int languageId);
    }
}
