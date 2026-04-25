using System.Security.Cryptography;
using System.Text;

// Note: CS0017 indicates there is more than one Main in the project.
// To fix CS0017 you must either remove/rename the other entry point(s)
// or specify the desired entry point via the compiler option: /main:<TypeName>

class Program
{
    static string storedHash = "";

    static void Main()
    {
        Console.Write("Enter password: ");
        string password = Console.ReadLine() ?? "";

        string hash = HashPassword(password);
        Console.WriteLine("Hashed Password: " + hash);

        storedHash = hash;
        File.WriteAllText("password.txt", hash);

        Console.Write("Re-enter password for login: ");
        string loginPassword = Console.ReadLine() ?? "";

        string loginHash = HashPassword(loginPassword);

        if (loginHash == storedHash)
            Console.WriteLine("Login Successful");
        else
            Console.WriteLine("Login Failed");

        Console.WriteLine("\nHTTPS ensures secure communication using SSL/TLS encryption.");
    }

    public static string HashPassword(string password)
    {
        using (SHA256 sha = SHA256.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}