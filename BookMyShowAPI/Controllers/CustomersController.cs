using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Models;

namespace BookMyShowAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        //CustomerDetails - id
        //customerBookings
        //CustomerBooking - id
        //CustomerTickets - BookingID
        //CustomerProfileUpdate - id
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return Enumerable.Range(1, 5).Select(index =>
             new Customer
             {
                 ID = index,
                 FirstName = "Ravi Teja",
                 Email = "raviteja6820@gmail.com",
                 Password = "password",
                 DisplayPicture = null,
                 Status = CustomerStatus.Regular,
                 CreationDate = DateTime.Now
             });
        }
    }
}
