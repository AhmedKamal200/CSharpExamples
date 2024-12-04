namespace LongRunningTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create and start a long-running task
            // TaskCreationOptions.LongRunning indicates the task will take a long time,
            // so a dedicated thread will be created (not part of the thread pool).
            var task = Task.Factory.StartNew(() => RunLongTask(),
                TaskCreationOptions.LongRunning);

            // Prevent the console from closing immediately
            // Waits for the user to press any key before exiting
            Console.ReadKey();
        }
    
        static void RunLongTask()
        {
            Thread.Sleep(3000);
            ShowThreadInfo(Thread.CurrentThread); // Show details about the thread running this task

            Console.WriteLine("Completed");
        }
        static void ShowThreadInfo(Thread th)
        {
            // Print:
            // - Thread ID: Unique identifier for the thread
            // - IsThreadPoolThread: Whether this thread belongs to the thread pool
            // - IsBackground: Whether this thread is a background thread
            Console.WriteLine($"TID: {th.ManagedThreadId}, Pooled: {th.IsThreadPoolThread}, Background: {th.IsBackground}");
        }
    }
}
