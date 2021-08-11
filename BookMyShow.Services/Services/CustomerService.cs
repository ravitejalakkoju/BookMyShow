using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.DBModels;
using BookMyShow.Models.User.Customer;
using AutoMapper;
using BookMyShow.Services.Interfaces;

namespace BookMyShow.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly DBContext _context;
        private readonly IMapper _mapper;

        public CustomerService(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public CustomerDTO Get(int id)
        {
            return _mapper.Map<CustomerDTO>(_context.SingleOrDefault<CustomerView>(id));
        }

        public CustomerDTO GetByEmail(string email)
        {
            PetaPoco.NetCore.Sql query = PetaPoco.NetCore.Sql.Builder
                        .Select("*")
                        .From("Customer")
                        .Where("Email=@0", email);

            return _mapper.Map<CustomerDTO>(_context.SingleOrDefault<CustomerView>(query));
        }

        public CustomerDTO Get(string email, string password)
        {
            PetaPoco.NetCore.Sql query = PetaPoco.NetCore.Sql.Builder
                        .Select("*")
                        .From("Customer")
                        .Where("Email=@0 and Password=@1", email, password);

            return _mapper.Map<CustomerDTO>(_context.SingleOrDefault<CustomerView>(query));
        }

        public string Create(CustomerDTO customerDTO)
        {
            Customer customer = _mapper.Map<Customer>(customerDTO);

            try
            {
                _context.Insert(customer);

                return null;
            }
            catch (System.Exception)
            {
                return "Email already exists";
            }
        }

        public void Update(CustomerDTO customerDTO)
        {
            Customer customer = _mapper.Map<Customer>(customerDTO);

            _context.Update("Customer", "ID", customer, customer.ID);
        }
    }
}
