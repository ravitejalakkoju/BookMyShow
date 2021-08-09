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

        public CustomerView Get(int customerId)
        {
            return _context.SingleOrDefault<CustomerView>(customerId);
        }

        public void Insert(Customer customer)
        {
            _context.Insert(customer);
        }

        public void Update(Customer customer)
        {
            _context.Update("Customer", "ID", customer, customer.ID);
        }
    }
}
