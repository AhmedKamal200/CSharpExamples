namespace Generic_Delegate
{
    internal class Program
    {
        public delegate bool Filter<in T>(T n);
        static void Main(string[] args)
        {
            IEnumerable<int> list = new int[] { 2, 5, 3, 8, 4, 7, 2, 9, 3, 4, };
            Console.WriteLine("number less than 6");
            Printnumber(list,n=> n< 6);
            Console.WriteLine("number less than 7");
            Printnumber(list, n => n < 7);
            Console.WriteLine("even numbers");
            Printnumber(list, n => n %2== 0);
            Console.ReadKey();
        }
        static void Printnumber<T>(IEnumerable<T> list,Filter<T> filter)
        {
            foreach (var n in list)
            {   
                if(filter(n))
                    Console.WriteLine(n);
            }


        }
    }
}
