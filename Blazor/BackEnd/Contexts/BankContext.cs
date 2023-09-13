using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BackEnd.Contexts
{
    public class BankContext: DbContext
    {
        protected readonly IConfiguration _configuration;
        public BankContext()
        {
            
        }
        public BankContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(_configuration.GetConnectionString("WebApiDatabase"));
    }
}
