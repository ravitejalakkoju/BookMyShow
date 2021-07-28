using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Entities;
using PetaPoco.NetCore;
using Microsoft.Extensions.Configuration;
using BookMyShow.Services;
using BookMyShow.Services.Repositories;

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationRepository _locationRepository;

        public LocationController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }
        // TheatresList - LocationID
        // Theatre - id
        // TheatreScreens - TheatreID
        // ShowsInTheatre - TheatreID, MovieID
        // SeatPrice - TheatreID, ScreenID
        public IEnumerable<Location> GetLocations()
        {
            var locations = _locationRepository.GetAll();

            return locations;
        }
    }
}
