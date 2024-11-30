namespace interface_practicalexample
{
    internal partial class Program
    {
        class Cashier
        {
            Ipayment payment;

            public Cashier(Ipayment payment)
            {
                this.payment = payment;
            }


            public void chechout(decimal amount)
            {
                payment.payout(amount);
            }


        }


    }
}
