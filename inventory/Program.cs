using System;
using System.Collections.Generic;

class Product
{
    private string name;
    private double price;
    private int quantity;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
                price = value;
            else
                Console.WriteLine("Price cannot be negative!");
        }
    }

    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value >= 0)
                quantity = value;
            else
                Console.WriteLine("Quantity cannot be negative!");
        }
    }
}

class ProductInventory
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product p)
    {
        products.Add(p);
    }

    public Product this[int index]
    {
        get { return products[index]; }
        set { products[index] = value; }
    }

    public void Display()
    {
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{i} -> {products[i].Name}, Price: {products[i].Price}, Quantity: {products[i].Quantity}");
        }
    }
}

class Program
{
    static void Main()
    {
        ProductInventory inventory = new ProductInventory();

        Console.Write("Enter number of products: ");
        int n = int.Parse(Console.ReadLine());

        // Adding products
        for (int i = 0; i < n; i++)
        {
            Product p = new Product();

            Console.WriteLine($"\nEnter details for Product {i}:");

            Console.Write("Name: ");
            p.Name = Console.ReadLine();

            Console.Write("Price: ");
            p.Price = double.Parse(Console.ReadLine());

            Console.Write("Quantity: ");
            p.Quantity = int.Parse(Console.ReadLine());

            inventory.AddProduct(p);
        }

        Console.WriteLine("\nAll Products:");
        inventory.Display();

        // Access using indexer
        Console.Write("\nEnter index to view product: ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine($"Product: {inventory[index].Name}");

        // Modify using indexer
        Console.Write("\nEnter index to modify product: ");
        int modIndex = int.Parse(Console.ReadLine());

        Product newProduct = new Product();

        Console.Write("New Name: ");
        newProduct.Name = Console.ReadLine();

        Console.Write("New Price: ");
        newProduct.Price = double.Parse(Console.ReadLine());

        Console.Write("New Quantity: ");
        newProduct.Quantity = int.Parse(Console.ReadLine());

        inventory[modIndex] = newProduct;

        Console.WriteLine("\nUpdated Products:");
        inventory.Display();
    }
}