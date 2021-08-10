using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;
using BookMyShow.Models.DTO;
using AutoMapper;
using BookMyShow.Services.Repositories.Interfaces;

namespace BookMyShow.Services
{
    public class CustomerService
    {
        private readonly ICustomerWrapper _customerWrapper;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerWrapper customerWrapper, IMapper mapper)
        {
            _mapper = mapper;
            _customerWrapper = customerWrapper;
        }

        public CustomerDTO GetCustomer(int id)
        {
            return _mapper.Map<CustomerDTO>(_customerWrapper.CustomerRepository.Get(id));
        }

        public CustomerDTO GetCustomerByEmail(string email)
        {
            return _mapper.Map<CustomerDTO>(_customerWrapper.CustomerRepository.GetByEmail(email));
        }

        public CustomerDTO GetCustomer(string email, string password)
        {
            return _mapper.Map<CustomerDTO>(_customerWrapper.CustomerRepository.Get(email, password));
        }

        public string CreateCustomer(CustomerDTO customerDTO)
        {
            return _customerWrapper.CustomerRepository.Insert(_mapper.Map<Customer>(customerDTO));
        }

        public void UpdateCustomer(CustomerDTO customerDTO)
        {
            _customerWrapper.CustomerRepository.Update(_mapper.Map<Customer>(customerDTO));
        }
    }
}
