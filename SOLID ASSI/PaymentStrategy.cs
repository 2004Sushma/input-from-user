namespace ECommerceApp
{
    public interface IPaymentStrategy
    {
        void Pay();
    }

    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay() => Console.WriteLine("Paid using Credit Card");
    }

    public class UPIPayment : IPaymentStrategy
    {
        public void Pay() => Console.WriteLine("Paid using UPI");
    }
}