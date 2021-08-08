using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface IMovieWrapper
    {
        public IMovieRepository MovieRepository { get; }

        public IGenreRepository GenreRepository { get; }

        public ILanguageRepository LanguageRepository { get; }

        public IMovie_Genre_Mapping_Repository Movie_Genre_Mapping_Repository { get; }

        public IMovie_Language_Mapping_Repository Movie_Language_Mapping_Repository { get; }
    }
}
