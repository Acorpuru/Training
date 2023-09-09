using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class BankService
    {
        public string Name { get; }
        protected Bank Bank { get; } = new Bank();

        public decimal GetNetAmount(int amount)
        {
            var tax = Bank.GetTaxPercentage();

            decimal netAmount = amount - (amount * tax);

            return netAmount;
        }
    }
}
