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
    public class TheatresController : ControllerBase
    {
        private TheatreService _theatreService;

        public TheatresController(TheatreService theatreService)
        {
            _theatreService = theatreService;
        }

        [HttpGet("{id}")]
        public TheatreDTO Get(int id)
        {
            return _theatreService.GetTheatre(id);
        }

        // GET api/<ValuesController>/5
        [HttpGet]
        public IEnumerable<TheatreDTO> Get(int locationId, int movieId)
        {
            return _theatreService.GetTheatresForMovieInLocation(locationId, movieId);
        }

    }
}
