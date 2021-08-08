using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Services.Repositories.Interfaces;
using BookMyShow.Models.DTO;
using AutoMapper;

namespace BookMyShow.Services
{
    public class LocationService
    {
        private readonly ILocationWrapper _locations;
        private readonly IMapper _mapper;
        
        public LocationService(ILocationWrapper locationWrapper, IMapper mapper)
        {
            _locations = locationWrapper;
            _mapper = mapper;
        }

        public LocationDTO GetLocation(int locationId)
        {
            var location = _locations.LocationRepository.GetView(locationId);

            return _mapper.Map<LocationDTO>(location);
        }

        public IEnumerable<LocationDTO> GetLocations()
        {
            return _mapper.Map<IEnumerable<LocationDTO>>(_locations.LocationRepository.GetAllViews());
        }
    }
}
