using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency.Threading
{
    public class ThreadConcurrency
    {
        private List<string> advisorAvailable = new() { "John", "Franck", "Martha" };

        public void CallFreeAdvisor()
        {
            var advisorName = string.Empty;
            try
            {
                if (advisorAvailable.Any())
                {
                    advisorName = advisorAvailable.First();
                    advisorAvailable.Remove(advisorName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(advisorName);
        }
    }

    public class ThreadConcurrencyLocked
    {
        private List<string> advisorAvailable = new() { "John", "Franck", "Martha" };
        private object lockObject = new object();

        public void CallFreeAdvisor()
        {
            lock (lockObject)
            {
                var advisorName = string.Empty;

                if (advisorAvailable.Any())
                {
                    advisorName = advisorAvailable.First();
                    advisorAvailable.Remove(advisorName);
                }
                Console.WriteLine(advisorName);
            }
        }
    }
    public class ThreadConcurrencyMonitor
    {
        private List<string> advisorAvailable = new() { "John", "Franck", "Martha" };
        private object lockObject = new object();

        public void CallFreeAdvisor()
        {
            try
            {
                Monitor.Enter(lockObject);
                var advisorName = string.Empty;

                if (advisorAvailable.Any())
                {
                    advisorName = advisorAvailable.First();
                    advisorAvailable.Remove(advisorName);
                }
                Console.WriteLine(advisorName);
            }
            finally
            {
                Monitor.Exit(lockObject);
            }
        }
    }
}
