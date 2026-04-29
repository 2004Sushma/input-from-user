namespace ECommerceApp
{
    public class PaymentContext
    {
        private IPaymentStrategy strategy;

        public void SetStrategy(IPaymentStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Pay()
        {
            strategy.Pay();
        }
    }
}