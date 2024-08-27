
namespace OOPS
{
    class Payment
    {
        public virtual void  MakePayment()
        {
            Console.WriteLine(" Choose a payment gate way ");
        }
    }

    class RazorpayPayment : Payment
    {
        public override void MakePayment()
        {
            Console.WriteLine(" Choose Razor payment ");
        }

    }
    class PaytmPayment : Payment
    {
        public override void MakePayment()
        {
            Console.WriteLine(" Choose Paytm payment ");
        }
    }
    internal class OverridingProgram
    {
        static void Main (string[] args)
        {
            Payment doPayment = new Payment();
            Payment doRazorpay = new RazorpayPayment();
            Payment doPaytmPayment = new PaytmPayment();
            doPayment.MakePayment();
            doRazorpay.MakePayment();
            doPaytmPayment.MakePayment();
        }
    }
}
