namespace interface_practicalexample
{
    internal partial class Program
    {
        class mastercard :Ipayment
        {
            public void payout(decimal amount)
            {
               Console.WriteLine($"payout by mastercard {amount}"); 
            }
        }


    }
}
