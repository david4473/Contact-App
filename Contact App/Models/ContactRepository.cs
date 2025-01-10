using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Contact = Contact_App.Models.Contact;

namespace Contact_App.Models
{
    public static class ContactRepository
    {

        public static List<Contact> _contacts = new List<Contact>()
        {
            new Contact {ContactId = 1, Name = "Frog", Email = "man@gmail.com", Address = "Ikorodu", Phone = "12345678"},
            new Contact {ContactId = 2, Name = "Lion", Email = "man@gmail.com", Address = "Ikorodu", Phone = "12345678"},
            new Contact {ContactId = 3, Name = "Egg", Email = "man@gmail.com", Address = "Ikorodu", Phone = "12345678"},
            new Contact {ContactId = 4, Name = "Pork", Email = "man@gmail.com", Address = "Ikorodu", Phone = "12345678"},
            new Contact {ContactId = 5, Name = "Pine", Email = "man@gmail.com", Address = "Ikorodu", Phone = "12345678"}

        };

        public static List<Contact> GetAllContacts() => _contacts;
        public static Contact GetContatctById(int contactId)
        {
            var contact = _contacts.FirstOrDefault(x => x.ContactId == contactId);

            if (contact != null)
            {
                return new Contact
                {
                    ContactId = contact.ContactId,
                    Name = contact.Name,
                    Email = contact.Email,
                    Phone = contact.Phone,
                    Address = contact.Address,
                };

            }
            return null;
        }

        public static void UpdateContact(int contactId, Contact contact)
        {
            if (contactId != contact.ContactId) return;

            var ContactToUpdate = _contacts.FirstOrDefault(x => x.ContactId == contactId);

            if (ContactToUpdate != null)
            {
                ContactToUpdate.Address = contact.Address;
                ContactToUpdate.Phone = contact.Phone;
                ContactToUpdate.Email = contact.Email;
                ContactToUpdate.Name = contact.Name;
            }

        }
    }
}
