using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;
using BookMyShow.Models.DTO;
using AutoMapper;

namespace BookMyShow.Services.AutoMapperProfiles
{
    public class TicketProfile: Profile
    {
        public TicketProfile()
        {
            CreateMap<TicketDTO, Ticket>();
        }
    }
}
