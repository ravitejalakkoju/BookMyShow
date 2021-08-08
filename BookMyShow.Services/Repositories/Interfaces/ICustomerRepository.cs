using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        public Customer Get(int customerId);

        public void Insert(Customer customer);
    }
}
