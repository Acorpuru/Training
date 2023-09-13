using BackEnd.Contracts;
using BackEnd.Models;

namespace BackEnd
{
    public class CustomerService : ICustomerService
    {
        private readonly List<Customer> _customers = new() { new() { CustomerId = 1 } };
        public List<Customer> GetCustomerDetails()
        {
            return _customers;
        }
    }
}
