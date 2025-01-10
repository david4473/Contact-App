using Contact_App.Models;
using Contact = Contact_App.Models.Contact;
using System.Security.Cryptography.X509Certificates;

namespace Contact_App.Views;

[QueryProperty(nameof(ContactId), "Id")]

public partial class EditContact : ContentPage
{
    private Contact contact;
    public EditContact()
    {
        InitializeComponent();
    }

    public String ContactId
    {
        set
        {
            contact = ContactRepository.GetContatctById(int.Parse(value));

            if (contact != null)
            {
                entryName.Text = contact.Name;
                entryEmail.Text = contact.Email;
                entryPhone.Text = contact.Phone;
                entryAddress.Text = contact.Address;
            }
        }
    }


    private void btnSave_Clicked(object sender, EventArgs e)
    {
        contact.Name = entryName.Text;
        contact.Email = entryEmail.Text;
        contact.Phone = entryPhone.Text;
        contact.Address = entryAddress.Text;

        ContactRepository.UpdateContact(contact.ContactId, contact);
        Shell.Current.GoToAsync("..");
    }
    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

}