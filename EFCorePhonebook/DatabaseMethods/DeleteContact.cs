using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePhonebook.DatabaseMethods
{
    internal class DeleteContact
    {
        internal void Delete()
        {
            ViewContact viewAll = new();
            viewAll.ReadAllContacts();

            Console.WriteLine("Choose the ID of the contact to update: ");
            string idInput = Console.ReadLine().Trim();
            int id = int.Parse(idInput);

            using (PhonebookContext context = new PhonebookContext())
            {
                var ctc = context.Contacts.First(c => c.Id == id);

                context.Contacts.Remove(ctc);

                context.SaveChanges();
            }
        }
    }
}
