using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using BookMyShow.Services;
using BookMyShow.Models.DTO;

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly LocationService _locationService;

        public LocationsController(LocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public IEnumerable<LocationDTO> Get()
        {
            var locations = _locationService.GetLocations();

            return locations;
        }

        [HttpGet("{locationId}")]
        public LocationDTO Get(int locationId)
        {
            var location = _locationService.GetLocation(locationId);

            return location;
        }
    }
}
