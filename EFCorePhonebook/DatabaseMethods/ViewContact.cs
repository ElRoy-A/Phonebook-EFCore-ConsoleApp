using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePhonebook.DatabaseMethods
{
    internal class ViewContact
    {
        PhonebookContext context = new PhonebookContext();
        internal void ReadAllContacts()
        {
            Console.Clear();

            var allContacts = context.Contacts.FromSqlRaw($"SELECT * FROM dbo.Contacts").ToList();

            DataVisualizer.ShowTable(allContacts);
        }

        internal void ReadContact()
        {
            Console.Clear();
            Console.Write("Enter a search condition: ");
            string userInput = Console.ReadLine();

            var searchContact = context.Contacts.Where(c => c.FirstName == userInput || c.LastName == userInput || c.PhoneNumber == userInput).ToList();

            if (searchContact.IsNullOrEmpty())
            {
                Console.WriteLine("\nNo contacts with those search parameters...");
            }

            DataVisualizer.ShowTable(searchContact);
        }
    }
}
