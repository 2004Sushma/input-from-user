namespace ECommerceApp
{
    public class Order
    {
        public string ProductName { get; set; }
        public string PaymentMethod { get; set; }
        public string Address { get; set; }

        public void ShowOrder()
        {
            Console.WriteLine($"Order: {ProductName}, Payment: {PaymentMethod}, Address: {Address}");
        }
    }
}