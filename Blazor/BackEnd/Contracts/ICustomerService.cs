using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Contracts
{
    public interface ICustomerService
    {
        public List<Customer> GetCustomerDetails();
    }
}
