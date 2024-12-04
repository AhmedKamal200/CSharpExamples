namespace ThreadVsTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //thread way
            var th = new Thread(() =>Display( "Ahmed Using Thread"));
            th.Start();
            th.Join();

            Task.Run(()=>Display("Ahmed using Thread")).Wait();
            Console.ReadKey();


        }
        static void Display(string message)
        {
            ShowThreadInfo(Thread.CurrentThread);
            Console.WriteLine(message);
        }

        private static void ShowThreadInfo(Thread th)
        {
            Console.WriteLine($"TID: {th.ManagedThreadId}, Pooled: {th.IsThreadPoolThread}, Background: {th.IsBackground}");
        }
    }
}
