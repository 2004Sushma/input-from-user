using System;
class NullValueException : Exception
{
    public NullValueException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        try
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NullValueException("Input should not be null or empty.");
            }

            Console.WriteLine("Valid input: " + name);
        }
        catch (NullValueException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
