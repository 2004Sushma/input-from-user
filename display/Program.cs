using System;
using System.Collections.Generic;

// Order class
class Order
{
    public int OrderId;
    public int CustomerId;
    public string Product;
    public string Category;

    public Stack<string> StatusHistory = new Stack<string>();

    public Order(int id, int custId, string product, string category)
    {
        OrderId = id;
        CustomerId = custId;
        Product = product;
        Category = category;

        StatusHistory.Push("Created");
    }
}

// Customer class
class Customer
{
    public int Id;
    public string Name;

    public Customer(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        // Collections
        List<Order> orders = new List<Order>();
        Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
        HashSet<string> categories = new HashSet<string>();
        Queue<Order> orderQueue = new Queue<Order>();

        // Add customers
        customers[1] = new Customer(1, "John");
        customers[2] = new Customer(2, "Alice");

        // Add orders
        Order o1 = new Order(101, 1, "Laptop", "Electronics");
        Order o2 = new Order(102, 2, "Shirt", "Clothing");

        orders.Add(o1);
        orders.Add(o2);

        categories.Add(o1.Category);
        categories.Add(o2.Category);

        orderQueue.Enqueue(o1);
        orderQueue.Enqueue(o2);

        // Process orders (FIFO)
        while (orderQueue.Count > 0)
        {
            Order current = orderQueue.Dequeue();
            current.StatusHistory.Push("Processing");

            Console.WriteLine($"Processing Order {current.OrderId}");
        }

        // Update order
        o1.StatusHistory.Push("Shipped");

        // Remove order
        orders.Remove(o2);

        // Show status history (LIFO)
        Console.WriteLine("\nOrder 101 Status History:");
        foreach (var status in o1.StatusHistory)
        {
            Console.WriteLine(status);
        }

        // Show unique categories
        Console.WriteLine("\nCategories:");
        foreach (var cat in categories)
        {
            Console.WriteLine(cat);
        }
    }
}