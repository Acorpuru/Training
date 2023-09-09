using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Bank
    {
        private decimal _amount = 0;
        public void CreditAmount(decimal amount)
        {
            _amount += amount;
        }

        public decimal GetSavings()
        {
            return _amount;
        }
    }
}
