namespace TaskReturnsValue
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            Task<DateTime> task = Task.Run(GetCurrentDatetime);
            //Console.WriteLine(task.Result); // block thread until result is ready

           // Console.WriteLine(task.GetAwaiter().GetResult()); // still pause the program till it fetches but
           // better when dealing with async task in sync code 
           // the better method :
            var result = await task;
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static DateTime GetCurrentDatetime() => DateTime.Now;

    }
}
