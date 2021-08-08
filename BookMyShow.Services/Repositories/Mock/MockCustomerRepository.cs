using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Services.Repositories.Interfaces;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories.Mock
{
    public class MockCustomerRepository: ICustomerRepository
    {
        private readonly DBContext _context;

        public MockCustomerRepository(DBContext context)
        {
            _context = context;
        }

        public Customer Get(int customerId)
        {
            return _context.SingleOrDefault<Customer>(customerId);
        }

        public void Insert(Customer customer)
        {
            _context.Insert(customer);
        }

        public void Update(Customer customer)
        {
            
        }
    }
}
