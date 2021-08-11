using BookMyShow.Models.User.Customer;

namespace BookMyShow.Services.Interfaces
{
    public interface ICustomerService
    {
        public CustomerDTO Get(int customerId);

        public CustomerDTO GetByEmail(string email);

        public CustomerDTO Get(string email, string password);

        public string Create(CustomerDTO customer);

        public void Update(CustomerDTO customer);
    }
}
