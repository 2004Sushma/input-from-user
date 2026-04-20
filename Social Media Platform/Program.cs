using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<string> posts = new List<string>();
        Dictionary<string, int> likes = new Dictionary<string, int>();
        HashSet<int> users = new HashSet<int>();
        Stack<string> actions = new Stack<string>();
        Queue<string> notifications = new Queue<string>();

        
        users.Add(1);
        users.Add(2);
        users.Add(1);

        
        posts.Add("Post1");
        posts.Add("Post2");

        
        likes["Post1"] = 0;
        likes["Post2"] = 0;

        likes["Post1"]++;

        
        actions.Push("User1 liked Post1");
        actions.Push("User2 posted Post2");

       
        actions.Pop();

        
        notifications.Enqueue("New like on Post1");
        notifications.Enqueue("New post added");

        string processed = notifications.Dequeue();

        
        Console.WriteLine("Users:");
        foreach (var u in users)
            Console.WriteLine(u);

        Console.WriteLine("\nPosts:");
        foreach (var p in posts)
            Console.WriteLine(p);

        Console.WriteLine("\nLikes:");
        foreach (var l in likes)
            Console.WriteLine($"{l.Key} -> {l.Value}");

        Console.WriteLine("\nActions:");
        foreach (var a in actions)
            Console.WriteLine(a);

        Console.WriteLine("\nProcessed Notification:");
        Console.WriteLine(processed);
    }
}