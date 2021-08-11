using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Services.Interfaces;
using BookMyShow.Models.User.Customer;
using Microsoft.AspNetCore.Authorization;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("{key}")]
        public CustomerDTO Get(string key, string s)
        {
            return s switch
            {
                "id" => _customerService.Get(Int32.Parse(key)),
                "email" => _customerService.GetByEmail(key),
                _ => null,
            };
        }

        [HttpGet("GetCustomer")]
        public CustomerDTO GetDetails(string email, string password)
        {
            //string email = HttpContext.User.Identity.Name;

            return  _customerService.Get(email, password);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public JsonResult Post([FromBody] CustomerDTO customerDTO)
        {
            return new JsonResult(_customerService.Create(customerDTO));
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] CustomerDTO customerDTO)
        {
            _customerService.Update(customerDTO);
        }
    }
}
