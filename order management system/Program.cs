using System;
using System.Collections.Generic;

// Order class
class Order
{
    public int OrderId;
    public int CustomerId;
    public string Product;
    public string Category;

    public Order(int orderId, int customerId, string product, string category)
    {
        OrderId = orderId;
        CustomerId = customerId;
        Product = product;
        Category = category;
    }
}

// Customer class
class Customer
{
    public int CustomerId;
    public string Name;

    public Customer(int id, string name)
    {
        CustomerId = id;
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
        Stack<string> statusHistory = new Stack<string>();

        // Add Customers
        customers.Add(1, new Customer(1, "Sushma"));
        customers.Add(2, new Customer(2, "Rahul"));

        // Add Orders
        Order o1 = new Order(101, 1, "Laptop", "Electronics");
        Order o2 = new Order(102, 2, "Book", "Education");
        Order o3 = new Order(103, 1, "Phone", "Electronics");

        orders.Add(o1);
        orders.Add(o2);
        orders.Add(o3);

        // Categories (duplicates ignored)
        categories.Add("Electronics");
        categories.Add("Education");
        categories.Add("Electronics");

        // Queue (FIFO)
        orderQueue.Enqueue(o1);
        orderQueue.Enqueue(o2);
        orderQueue.Enqueue(o3);

        // Process one order
        Order processedOrder = orderQueue.Dequeue();

        // Stack (LIFO)
        statusHistory.Push("Order Placed");
        statusHistory.Push("Order Shipped");
        statusHistory.Push("Delivered");

        // Remove latest status
        statusHistory.Pop();

        // Print Orders
        Console.WriteLine("All Orders:");
        foreach (var order in orders)
        {
            Console.WriteLine($"OrderId: {order.OrderId}, Product: {order.Product}");
        }

        // Processed Order
        Console.WriteLine("\nProcessed Order:");
        Console.WriteLine($"OrderId: {processedOrder.OrderId}, Product: {processedOrder.Product}");

        // Status History
        Console.WriteLine("\nStatus History:");
        foreach (var status in statusHistory)
        {
            Console.WriteLine(status);
        }

        // Categories
        Console.WriteLine("\nUnique Categories:");
        foreach (var cat in categories)
        {
            Console.WriteLine(cat);
        }
    }
}