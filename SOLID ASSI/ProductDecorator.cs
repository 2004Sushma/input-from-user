namespace ECommerceApp
{
    public abstract class ProductDecorator : Product
    {
        protected Product product;

        public ProductDecorator(Product product)
        {
            this.product = product;
        }
    }

    public class DiscountDecorator : ProductDecorator
    {
        public DiscountDecorator(Product product) : base(product) { }

        public override string GetDetails()
        {
            return product.GetDetails() + " + Discount Applied";
        }
    }
}