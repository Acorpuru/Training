using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IAlertNotification
    {
        void SendNotification(BankAccountSaving saving);
    }
    public class AlertNotification : IAlertNotification
    {
        public void SendNotification(BankAccountSaving saving)
        {
            throw new NotImplementedException();
        }
    }
}
