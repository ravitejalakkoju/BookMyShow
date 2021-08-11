using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.DBModels;
using BookMyShow.Models.User.Customer;
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
