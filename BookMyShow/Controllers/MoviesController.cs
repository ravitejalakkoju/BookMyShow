using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Services;
using BookMyShow.Models.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public MovieService _movieService;

        public MoviesController(MovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<MovieDTO> Get(int locationId)
        {
            return _movieService.GetMoviesByLocation(locationId);
        }

        [HttpGet("languages")]
        public IEnumerable<LanguageDTO> Get()
        {
            return _movieService.GetLanguages();
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public MovieDTO GetDetails(int id)
        {
            return _movieService.GetMovieDetails(id);
        }
    }
}
