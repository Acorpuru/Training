using System.Diagnostics;

namespace Asynchrone.AsyncAwait
{
    public static class CancellationToken
    {
        public static async Task ThrowTokenFor(Func<Task> MyAsyncMethod)
        {

            var stopWatch = Stopwatch.StartNew();

            try
            {
                await MyAsyncMethod();
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine($"Cancellation token throw before running");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine($"Cancellation token throw");
            }
            catch (Exception)
            {
                Console.WriteLine($"Exception for Cancellation not handled gracefully");
            }

            stopWatch.Stop();
            Console.WriteLine($"Time elapsed {stopWatch.Elapsed}");
        }

        public static async Task MyCancellationMethodAsync(string tag, int delayInMillisecond, System.Threading.CancellationToken cancellationToken = default)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    Console.WriteLine($"My Method Async {tag}");
                    cancellationToken.ThrowIfCancellationRequested();
                    Task.Delay(delayInMillisecond).Wait();
                }
            }, cancellationToken);
        }
        public static async Task MyCancellationMethodWithLinkedTokenAsync(string tag, int delayInMillisecond, System.Threading.CancellationToken cancellationToken = default)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            cancellationTokenSource.CancelAfter(2000);
            System.Threading.CancellationToken internalToken = cancellationTokenSource.Token;

            using var cancellationLinkedTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationTokenSource.Token, cancellationToken);

            await Task.Run(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    Console.WriteLine($"My Method Async {tag}");
                    cancellationLinkedTokenSource.Token.ThrowIfCancellationRequested();
                    Task.Delay(delayInMillisecond).Wait();
                }
            }, cancellationLinkedTokenSource.Token);
        }
        public static async Task MyCancellationMethodAsyncWithSleep(string tag, int delayInMillisecond, System.Threading.CancellationToken cancellationToken = default)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine($"My Method Async {tag}");
                Thread.Sleep(delayInMillisecond);
            }
            Console.WriteLine("Task Ended");
        }
        public static async Task MyCancellationMethodAsyncWithDelay(string tag, int delayInMillisecond, System.Threading.CancellationToken cancellationToken = default)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine($"My Method Async {tag}");
                await Task.Delay(delayInMillisecond);
            }
            Console.WriteLine("Task Ended");
        }
    }
}
