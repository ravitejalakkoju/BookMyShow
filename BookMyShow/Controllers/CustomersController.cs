using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Services;
using BookMyShow.Models.DTO;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomersController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("{id}")]
        public CustomerDTO Get(int id)
        {
            return _customerService.GetCustomer(id);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] CustomerDTO customerDTO)
        {
            _customerService.CreateCustomer(customerDTO);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CustomerDTO customerDTO)
        {
            _customerService.UpdateCustomer(customerDTO);
        }
    }
}
