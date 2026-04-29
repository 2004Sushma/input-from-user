namespace ECommerceApp
{
    public class OrderBuilder
    {
        private Order order = new Order();

        public OrderBuilder SetProduct(string product)
        {
            order.ProductName = product;
            return this;
        }

        public OrderBuilder SetPayment(string payment)
        {
            order.PaymentMethod = payment;
            return this;
        }

        public OrderBuilder SetAddress(string address)
        {
            order.Address = address;
            return this;
        }

        public Order Build()
        {
            return order;
        }
    }
}