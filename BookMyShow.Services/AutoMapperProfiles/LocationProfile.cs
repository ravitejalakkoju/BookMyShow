using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BookMyShow.Models.Location;
using BookMyShow.DBModels;

namespace BookMyShow.Services.AutoMapperProfiles
{
    public class LocationProfile: Profile
    {
        public LocationProfile()
        {
            CreateMap<Location, LocationDTO>()
                .ForSourceMember(x => x.StateID, opt => opt.DoNotValidate());

            CreateMap<LocationView, LocationDTO>()
                .ForSourceMember(x => x.StateID, opt => opt.DoNotValidate())
                .ForSourceMember(x => x.StateName, opt => opt.DoNotValidate());
        }
    }
}
