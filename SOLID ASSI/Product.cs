namespace ECommerceApp
{
    public abstract class Product
    {
        public abstract string GetDetails();
    }

    public class Electronics : Product
    {
        public override string GetDetails() => "Electronics Product";
    }

    public class Clothing : Product
    {
        public override string GetDetails() => "Clothing Product";
    }
}