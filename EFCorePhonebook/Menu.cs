using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCorePhonebook.DatabaseMethods;

namespace EFCorePhonebook
{
    internal class Menu
    {
        internal void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("Welcome to the Phonebook Application");
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("Please choose from the following options:");
            Console.WriteLine("1 - View All Contacts");
            Console.WriteLine("2 - View a Contact");
            Console.WriteLine("3 - Add a New Contact");
            Console.WriteLine("4 - Update a Contact");
            Console.WriteLine("5 - Delete a Contact");
            Console.WriteLine("0 - Exit Application");

            Console.Write("\nEnter your choice: ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Environment.Exit(0);
                    break;

                case "1":
                    // View all contacts
                    ViewContact readAll = new();
                    readAll.ReadAllContacts();
                    ReturnToMenu();
                    break;

                case "2":
                    // View one contact
                    ViewContact read = new();
                    read.ReadContact();
                    ReturnToMenu();
                    break;

                case "3":
                    // Insert new contact
                    AddContact create = new();
                    create.InsertContact();
                    ReturnToMenu();
                    break;

                case "4":
                    // Update a contact
                    UpdateContact update = new();
                    update.Update();
                    ReturnToMenu();
                    break;

                case "5":
                    // Delete a contact
                    DeleteContact delete = new();
                    delete.Delete();
                    ReturnToMenu();
                    break;

                default:
                    Console.WriteLine("\nInvalid choice. Press any key to try again");
                    Console.ReadKey();
                    MainMenu();
                    break;
            }
        }

        internal void ReturnToMenu()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Menu menu = new();
            menu.MainMenu();
        }
    }
}
