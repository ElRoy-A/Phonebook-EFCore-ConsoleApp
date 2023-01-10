using EFCorePhonebook;
using Microsoft.Data.SqlClient;

namespace EFCorePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing SQL DB connection...");

            string connectionString = "Data Source=A30562;Initial Catalog=PhonebookDB;Trusted_Connection=True;Trust Server Certificate=True;";

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                Console.WriteLine("Opening Connection...");

                connection.Open();

                Console.WriteLine("Connection successful!");

                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.Write("\nPress any key to progress to the main menu...");
            Console.ReadKey();

            Menu menu = new Menu();
            menu.MainMenu();
        }
    }
}