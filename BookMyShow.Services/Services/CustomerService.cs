﻿using System;
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

        public CustomerDTO GetCustomer(int customerID)
        {
            return _mapper.Map<CustomerDTO>(_customerWrapper.CustomerRepository.Get(customerID));
        }

        public void CreateCustomer(CustomerDTO customerDTO)
        {
            _customerWrapper.CustomerRepository.Insert(_mapper.Map<Customer>(customerDTO));
        }

        public void UpdateCustomer(CustomerDTO customerDTO)
        {
            _customerWrapper.CustomerRepository.Update(_mapper.Map<Customer>(customerDTO));
        }
    }
}