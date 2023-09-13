using System.Diagnostics;

namespace Concurrency.Threading
{
    public static class ThreadExample
    {
        public static void LaunchThread()
        {

            Console.WriteLine("Begin Thread");
            Thread.Sleep(1000);
            Console.WriteLine("End Thread");
        }

        public static void LaunchThread(string? threadName = null)
        {

            Console.WriteLine("Begin Thread");
            if (threadName is string name)
                Console.WriteLine($"name of thread {name}");
            Thread.Sleep(1000);
            Console.WriteLine("End Thread");
        }
    }
}
