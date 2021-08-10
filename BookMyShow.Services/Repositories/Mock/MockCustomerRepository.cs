using BookMyShow.Services.Repositories.Interfaces;
using BookMyShow.Entities;
using PetaPoco.NetCore;

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

        public CustomerView GetByEmail(string email)
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Customer")
                        .Where("Email=@0", email);

            return _context.SingleOrDefault<CustomerView>(query);
        }

        public CustomerView Get(string email, string password)
        {
            Sql query = Sql.Builder
                        .Select("*")
                        .From("Customer")
                        .Where("Email=@0 and Password=@1", email, password);

            return _context.SingleOrDefault<CustomerView>(query);
        }
        public string Insert(Customer customer)
        {
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

        public void Update(Customer customer)
        {
            _context.Update("Customer", "ID", customer, customer.ID);
        }

    }
}
