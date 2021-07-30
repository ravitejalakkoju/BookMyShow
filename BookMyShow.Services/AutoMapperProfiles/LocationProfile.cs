using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BookMyShow.Models;

namespace BookMyShow.Services.AutoMapperProfiles
{
    public class LocationProfile: Profile
    {
        public LocationProfile()
        {
            CreateMap<Location, LocationDTO>();
            CreateMap<IEnumerable<Location>, IEnumerable<LocationDTO>>();
        }
    }
}
