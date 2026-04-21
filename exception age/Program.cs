using System;


class AgeException : Exception
{
    public AgeException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter age:");
        int age = int.Parse(Console.ReadLine());

        if (age < 18)
        {
            throw new AgeException("Age must be 18 or above.");
        }

        Console.WriteLine("Valid age");
    }
}