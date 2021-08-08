using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Services.Repositories.Interfaces;
using BookMyShow.Services.Repositories.Mock;

namespace BookMyShow.Services.Repositories.Mock
{
    public class MockMovieWrapper : IMovieWrapper
    {
        public DBContext _context;

        public IMovieRepository _movieRepository;
        public IGenreRepository _genreRepository;
        public ILanguageRepository _languageRepository;
        public IMovie_Genre_Mapping_Repository _movie_Genre_Mapping_Repository;
        public IMovie_Language_Mapping_Repository _movie_Language_Mapping_Repository;

        public MockMovieWrapper(DBContext context)
        {
            _context = context;
        }

        public IMovieRepository MovieRepository
        {
            get
            {
                if(_movieRepository == null)
                {
                    _movieRepository = new MockMovieRepository(_context);
                }
                return _movieRepository;
            }
        }
        public IGenreRepository GenreRepository
        {
            get
            {
                if (_genreRepository == null)
                {
                    _genreRepository = new MockGenreRepository(_context);
                }
                return _genreRepository;
            }
        }
        public ILanguageRepository LanguageRepository
        {
            get
            {
                if (_languageRepository == null)
                {
                    _languageRepository = new MockLanguageRepository(_context);
                }
                return _languageRepository;
            }
        }
        public IMovie_Genre_Mapping_Repository Movie_Genre_Mapping_Repository
        {
            get
            {
                if (_movie_Genre_Mapping_Repository == null)
                {
                    _movie_Genre_Mapping_Repository = new MockMovie_Genre_Mapping_Repository(_context);
                }
                return _movie_Genre_Mapping_Repository;
            }
        }
        public IMovie_Language_Mapping_Repository Movie_Language_Mapping_Repository
        {
            get
            {
                if (_movie_Language_Mapping_Repository == null)
                {
                    _movie_Language_Mapping_Repository = new MockMovie_Language_Mapping_Repository(_context);
                }
                return _movie_Language_Mapping_Repository;
            }
        }
    }
}
