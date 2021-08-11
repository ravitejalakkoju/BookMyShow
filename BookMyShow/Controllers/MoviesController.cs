using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Services.Interfaces;
using BookMyShow.Models.Movie;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public IMovieService _movieService;
        private readonly ILanguageService _languageService;
        private readonly IGenreService _genreService;
        public MoviesController(IMovieService movieService, ILanguageService languageService, IGenreService genreService)
        {
            _movieService = movieService;
            _languageService = languageService;
            _genreService = genreService;
        }

        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<MovieDTO> Get(int locationId)
        {
            return _movieService.GetAllAtLocation(locationId);
        }

        [HttpGet("languages")]
        public IEnumerable<LanguageDTO> GetLanguages()
        {
            return _languageService.GetAll();
        }

        [HttpGet("genres")]
        public IEnumerable<GenreDTO> GetGenres()
        {
            return _genreService.GetAll();
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public MovieDTO GetMovieDetails(int id)
        {
            return _movieService.GetDetails(id);
        }
    }
}
