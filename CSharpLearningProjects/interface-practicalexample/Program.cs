namespace interface_practicalexample
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Cashier cashier = new Cashier(new cash());
            cashier.chechout(100);
            Cashier cashier1 = new Cashier(new mastercard());
            cashier1.chechout(100);
            Cashier cashier2 = new Cashier(new visa());
            cashier2.chechout(100);
            Console.ReadKey();

            
        }


    }
}
