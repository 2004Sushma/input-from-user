using System;

namespace ECommerceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 🔹 Factory Pattern
            var product = ProductFactory.CreateProduct("Electronics");
            Console.WriteLine(product.GetDetails());

            // 🔹 Decorator Pattern
            var discountedProduct = new DiscountDecorator(product);
            Console.WriteLine(discountedProduct.GetDetails());

            // 🔹 Strategy Pattern
            var payment = new PaymentContext();
            payment.SetStrategy(new UPIPayment());
            payment.Pay();

            // 🔹 Builder Pattern
            var order = new OrderBuilder()
                .SetProduct("Laptop")
                .SetPayment("UPI")
                .SetAddress("Nellore")
                .Build();

            order.ShowOrder();

            // 🔹 Observer Pattern
            var notifier = new OrderNotifier();
            var customer = new Customer();

            notifier.Attach(customer);
            notifier.Notify("Order Placed Successfully");
        }
    }
}