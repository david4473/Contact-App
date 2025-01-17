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

        public static void AddContact(Contact contact)
        {
            var MaxId = _contacts.Max(x => x.ContactId);
            contact.ContactId = MaxId + 1;
            _contacts.Add(contact);
        }

        public static void DeleteContact(int contactId)
        {
            var contact = _contacts.FirstOrDefault(x => x.ContactId == contactId);
            if (contact != null)
            {
                _contacts.Remove(contact);
            }
        }

        public static List<Contact> SearchContact(String filterText)
        {
            var contacts = _contacts.Where(x => !String.IsNullOrWhiteSpace(x.Name) && x.Name.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();

            if (contacts == null || contacts.Count <= 0)
                contacts = _contacts.Where(x => !String.IsNullOrWhiteSpace(x.Email) && x.Email.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();
            else
                return contacts;
            if (contacts == null || contacts.Count <= 0)
                contacts = _contacts.Where(x => !String.IsNullOrWhiteSpace(x.Phone) &&  x.Phone.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();
            else
                return contacts;
            if (contacts == null || contacts.Count <= 0)
                contacts = _contacts.Where(x => !String.IsNullOrWhiteSpace(x.Address) && x.Address.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();
            else
                return contacts;

            return contacts;
        }
    }
}
