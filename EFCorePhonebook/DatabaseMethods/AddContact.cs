using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePhonebook.DatabaseMethods
{
    internal class AddContact
    {
        internal void InsertContact()
        {
            Console.Clear();

            Contact contact = new Contact();

            contact = AddContactMenu();

            using (PhonebookContext context = new PhonebookContext())
            {
                context.Contacts.Add(contact);
                context.SaveChanges();

                Console.WriteLine("Query executed...\n\nContact added to database.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Menu menu = new Menu();
            menu.MainMenu();
        }

        internal Contact AddContactMenu()
        {
            Contact contact = new Contact();

            Console.Write("First Name: ");
            contact.FirstName = Console.ReadLine().Trim();

            Console.Write("\nLast Name: ");
            contact.LastName = Console.ReadLine().Trim();

            Console.Write("\nPhone Number: ");
            contact.PhoneNumber = Console.ReadLine().Trim();

            return contact;
        }
    }
}
