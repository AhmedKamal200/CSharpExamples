namespace dateandtime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt =new DateTime(2022, 1, 1); // date time is a read only struct
            Console.WriteLine(dt);
            dt = dt.AddDays(20);// so it's immutable we do that not dt.AddDays(20);
            Console.WriteLine(dt);
            Console.ReadKey();
        }
    }
}
