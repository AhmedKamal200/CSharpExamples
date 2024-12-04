namespace TaskContinuation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = Task.Run(() => CountPrimeNumberInARange(2, 3_000_000));
            task.ContinueWith((x) => Console.WriteLine(x.Result));
            Console.WriteLine("Ahmed");
            Console.ReadKey();

        }
        static int CountPrimeNumberInARange(int lowerBound, int upperBound)
        {
            var count = 0;
            for (int i = lowerBound; i < upperBound; i++)
            {
                var j = 2;
                var isPrime = true;
                while (j <= (int)Math.Sqrt(i))
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    ++j;
                }

                if (isPrime)
                    ++count;
            }
            return count;
        }
    

    }
}
