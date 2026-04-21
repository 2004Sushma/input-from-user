using System;
class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        try
        {
            if (num < 0)
            {
                throw new NegativeNumberException("Number should not be negative.");
            }

            Console.WriteLine("Valid number");
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}
