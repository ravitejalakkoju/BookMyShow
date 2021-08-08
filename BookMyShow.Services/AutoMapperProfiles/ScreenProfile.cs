using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Models.DTO;
using BookMyShow.Entities;
using AutoMapper;

namespace BookMyShow.Services.AutoMapperProfiles
{
    public class ScreenProfile: Profile
    {
        public ScreenProfile()
        {
            CreateMap<Screen, ScreenDTO>();
            CreateMap<Seat, SeatDTO>();
        }
    }
}
