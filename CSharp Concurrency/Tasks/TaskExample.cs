using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency.Tasks
{
    public class TestTask
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"{Name} {LastName}";
    }
    public class TaskExample
    {
        public void LaunchTask()
        {

            Console.WriteLine("Begin Task");
            Task.Delay(1000);
            Console.WriteLine("End Task");
        }
        public void LaunchTask(object? testTask)
        {
            Console.WriteLine($"Begin Task for {testTask}");
            Task.Delay(1000);
            Console.WriteLine("End Task");
        }
        public int AddSameNumber(int number)
        {
            number += number;
            Console.WriteLine(number);
            return number;
        }
    }
}
