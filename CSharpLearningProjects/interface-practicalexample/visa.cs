namespace interface_practicalexample
{
    internal partial class Program
    {
        class visa : Ipayment
        {
            public void payout(decimal amount)
            {
                Console.WriteLine($"payout by visa {amount}");
            }
        }


    }
}
