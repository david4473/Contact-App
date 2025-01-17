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
                contactCtrl.Name = contact.Name;
                contactCtrl.Email = contact.Email;
                contactCtrl.Phone = contact.Phone;
                contactCtrl.Address = contact.Address;
            }
        }
    }


    private void btnSave_Clicked(object sender, EventArgs e)
    {
        contact.Name = contactCtrl.Name;
        contact.Email = contactCtrl.Email;
        contact.Phone = contactCtrl.Phone;
        contact.Address = contactCtrl.Address;

        ContactRepository.UpdateContact(contact.ContactId, contact);
        Shell.Current.GoToAsync("..");
    }
    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void ContactControl_OnError(object sender, String e)
    {
        DisplayAlert("Error", e, "close");
    }

}