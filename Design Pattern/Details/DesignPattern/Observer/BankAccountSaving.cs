using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class BankAccountSaving
    {
        public string BankAccountNumber { get; private set; }
        public decimal Saving { get; private set; }
        
        public BankAccountSaving(string bankAccountNumber, decimal saving)
        {
            BankAccountNumber = bankAccountNumber;
            Saving = saving;
        }
        public void UpdateSavingAmount(decimal amount)
        {
            Saving += amount;
        }
    }
}
