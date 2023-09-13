using BackEnd.Contexts;
using BackEnd.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace BackEnd
{
    public static class StartupEf
    {
        public static void AddBackEndContext(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<BankContext>();
            serviceCollection.AddSingleton<ICustomerService, CustomerService>();
        }
    }
}
