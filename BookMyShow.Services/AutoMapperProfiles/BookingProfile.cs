using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BookMyShow.Entities;
using BookMyShow.Models.DTO;

namespace BookMyShow.Services.AutoMapperProfiles
{
    public class BookingProfile: Profile
    {
        public BookingProfile()
        {
            CreateMap<Booking, BookingDTO>().ReverseMap();
            CreateMap<BookingByCustomer, BookingByCustomerDTO>();
        }
    }
}
