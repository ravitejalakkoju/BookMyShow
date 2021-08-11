using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using BookMyShow.Services.Interfaces;
using BookMyShow.Models.Location;

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationsController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public IEnumerable<LocationDTO> Get()
        {
            var locations = _locationService.GetAll();

            return locations;
        }

        [HttpGet("{locationId}")]
        public LocationDTO Get(int locationId)
        {
            var location = _locationService.Get(locationId);

            return location;
        }
    }
}
