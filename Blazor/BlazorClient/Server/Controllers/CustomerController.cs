using BackEnd.Contracts;
using M = BackEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClient.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IEnumerable<M.Customer> Get()
        {
            return _customerService.GetCustomerDetails();
        }
    }
}
