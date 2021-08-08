using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BookMyShow.Models.DTO;
using BookMyShow.Entities;

namespace BookMyShow.Services.AutoMapperProfiles
{
    public class TheatreProfile: Profile
    {
        public TheatreProfile()
        {
            CreateMap<Theatre, TheatreDTO>();
            CreateMap<TheatreView, TheatreDTO>();
        }
    }
}
