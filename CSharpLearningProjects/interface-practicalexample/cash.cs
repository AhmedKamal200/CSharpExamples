namespace interface_practicalexample
{
    internal partial class Program
    {
        class cash :Ipayment
        {
            public void payout(decimal amount)
            {
                Console.WriteLine($"payout by cash {amount}");
            }
        }


    }
}
