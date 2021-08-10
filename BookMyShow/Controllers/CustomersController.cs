using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Services;
using BookMyShow.Models.DTO;
using Microsoft.AspNetCore.Authorization;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookMyShow.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomersController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public CustomerDTO Get(string email, string password)
        {
            switch (s)
            {
                case "id":
                    return _customerService.GetCustomer(Int32.Parse(key));
                case "email":
                    return _customerService.GetCustomerByEmail(key);
                default:
                    return null;
            }
            
        }

        // POST api/<CustomersController>
        [HttpPost]
        public JsonResult Post([FromBody] CustomerDTO customerDTO)
        {
            return new JsonResult(_customerService.CreateCustomer(customerDTO));
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CustomerDTO customerDTO)
        {
            _customerService.UpdateCustomer(customerDTO);
        }
    }
}
