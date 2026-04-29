namespace ECommerceApp
{
    public class ProductFactory
    {
        public static Product CreateProduct(string type)
        {
            return type switch
            {
                "Electronics" => new Electronics(),
                "Clothing" => new Clothing(),
                _ => null
            };
        }
    }
}