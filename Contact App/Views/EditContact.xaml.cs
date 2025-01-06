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
            lbll.Text = contact.Name;
        }
    }

    
}