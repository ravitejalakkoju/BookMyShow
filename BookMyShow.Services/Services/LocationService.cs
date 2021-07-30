using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Services.Repositories.Interfaces;
using BookMyShow.Models;
using AutoMapper;

namespace BookMyShow.Services
{
    public class LocationService
    {
        private readonly ILocationRepository _locations;
        private readonly IMapper _mapper;
        
        public LocationService(ILocationRepository locationRepository, IMapper mapper)
        {
            _locations = locationRepository;
            _mapper = mapper;
        }

        public LocationDTO GetLocation(int locationId)
        {
            return _mapper.Map<LocationDTO>(_locations.Get(locationId));
        }

        public IEnumerable<LocationDTO> GetLocations()
        {
            return _mapper.Map<IEnumerable<LocationDTO>>(_locations.GetAll());
        }
    }
}
