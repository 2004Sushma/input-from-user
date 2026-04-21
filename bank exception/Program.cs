using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message) { }
}

class InvalidAmountException : Exception
{
    public InvalidAmountException(string message) : base(message) { }
}

class BankAccount
{
    public string AccountHolderName { get; set; }
    public double Balance { get; set; }

    public BankAccount(string name, double balance)
    {
        AccountHolderName = name;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new InvalidAmountException("Deposit amount must be greater than 0");

        Balance += amount;
        Console.WriteLine("Amount deposited successfully");
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
            throw new InsufficientBalanceException("Insufficient balance");

        if (Balance - amount < 1000)
            throw new InsufficientBalanceException("Minimum balance should be ₹1000");

        Balance -= amount;
        Console.WriteLine("Withdrawal successful");
    }

    public void CheckBalance()
    {
        Console.WriteLine("Current Balance: " + Balance);
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("User", 5000);

        try
        {
            account.Deposit(1000);
            account.Withdraw(2000);
            account.CheckBalance();

            account.Deposit(-500);
        }
        catch (InvalidAmountException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction completed");
        }
    }
}
