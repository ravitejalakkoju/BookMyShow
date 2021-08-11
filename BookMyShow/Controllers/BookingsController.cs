using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Services.Interfaces;
using BookMyShow.Models.User.Customer;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        // GET: api/<BookingsController>
        [HttpGet]
        public IEnumerable<BookingByCustomerDTO> GetByCustomer(int customerId)
        {
            return _bookingService.GetAllByCustomer(customerId);
        }

        // GET api/<BookingsController>/5
        [HttpGet("{id}")]
        public BookingByCustomerDTO Get(int id)
        {
            return _bookingService.Get(id);
        }

        // POST api/<BookingsController>
        [HttpPost]
        public Object Post([FromBody] BookingDTO bookingDto)
        {
            return _bookingService.Create(bookingDto);
        }
    }
}
