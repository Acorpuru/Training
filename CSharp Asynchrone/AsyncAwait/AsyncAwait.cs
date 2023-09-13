namespace Asynchrone.AsyncAwait
{
    public static class AsyncAwait
    {
        public static async Task DisplayMethodAsync(string tag, int delayInMillisecond)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"My Method Async {tag}");
                await Task.Delay(delayInMillisecond);
            }
        }
        public static void DisplayMethod(string tag, int delayInMillisecond)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"My Method Async {tag}");
                Thread.Sleep(delayInMillisecond);
            }
        }
    }
}