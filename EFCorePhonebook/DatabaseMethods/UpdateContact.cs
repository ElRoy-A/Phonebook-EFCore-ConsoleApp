using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePhonebook.DatabaseMethods
{
    internal class UpdateContact
    {
        internal void Update()
        {
            ViewContact viewAll = new();
            viewAll.ReadAllContacts();

            Console.WriteLine("Choose the ID of the contact to update: ");
            string idInput = Console.ReadLine().Trim();
            int id = int.Parse(idInput);
            // Validate ID is a numeric and exists in database

            Console.WriteLine("Choose to update: ");
            Console.WriteLine("1 - First Name");
            Console.WriteLine("2 - Last Name");
            Console.WriteLine("3 - Phone Number");

            Console.Write("Update choice: ");
            string updateChoice = Console.ReadLine();

            Console.Write("Update entry: ");
            string updateInput = Console.ReadLine();

            using (PhonebookContext context = new PhonebookContext())
            {
                var ctc = context.Contacts.First(c => c.Id == id);
                
                if (updateChoice == "1")
                {
                    ctc.FirstName = updateInput;
                }
                else if (updateChoice == "2")
                {
                    ctc.LastName = updateInput;
                }
                else if (updateChoice == "3") 
                {
                    ctc.PhoneNumber = updateInput;
                }

                context.SaveChanges();
            }
        }
    }
}
