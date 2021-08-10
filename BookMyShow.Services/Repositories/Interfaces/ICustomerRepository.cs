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
        //public CustomerView Get(int customerId);

        public CustomerView Get(string email, string password);

        public string Insert(Customer customer);

        public void Update(Customer customer);
    }
}
