using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_App.Models
{
    public static class ContactRepository
    {

        public static List<Contact> _contacts = new List<Contact>() 
        {
            new Contact {ContactId = 1, Name = "Frog", Email = "man@gmail.com"},
            new Contact {ContactId = 2, Name = "Lion", Email = "man@gmail.com"},
            new Contact {ContactId = 3, Name = "Egg", Email = "man@gmail.com"},
            new Contact {ContactId = 4, Name = "Pork", Email = "man@gmail.com"},
            new Contact {ContactId = 5, Name = "Pine", Email = "man@gmail.com"}

        };

        public static List<Contact> GetAllContacts() => _contacts;
        public static Contact GetContatctById(int contactId) 
        {
            return _contacts.FirstOrDefault(x => x.ContactId == contactId);
        }
        

    }
}
