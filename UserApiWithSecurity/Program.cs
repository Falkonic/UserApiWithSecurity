using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (AuthenticateUser(username, password))
        {
            Console.WriteLine("Login successful!");
            if (IsAdmin(username))
            {
                Console.WriteLine("Welcome, Admin. You have full access.");
            }
            else
            {
                Console.WriteLine("Welcome, User. Limited access.");
            }
        }
        else
        {
            Console.WriteLine("Login failed!");
        }
    }

    public static bool AuthenticateUser(string username, string password)
    {
        string connectionString = "Data Source=.;Initial Catalog=SafeVault;Integrated Security=True";
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND PasswordHash = HASHBYTES('SHA2_256', @password)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int count = (int)cmd.ExecuteScalar();
                return count == 1;
            }
        }
    }

    static bool IsAdmin(string username)
    {
        // Beispiel: Rolle prüfen
        return username.ToLower() == "admin";
    }
}
