using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BookMyShow.DBModels;
using BookMyShow.Models.User.Customer;

namespace BookMyShow.Services.AutoMapperProfiles
{
    public class CustomerProfile: Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerView, CustomerDTO>().ReverseMap();
            CreateMap<Customer, CustomerDTO>().ReverseMap();
        }
    }
}
