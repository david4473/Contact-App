using Contact_App.Models;

namespace Contact_App.Views;

public partial class AddContact : ContentPage
{
    public AddContact()
    {
        InitializeComponent();
    }

    private void ContactControl_OnSave(object sender, EventArgs e)
    {
        ContactRepository.AddContact(new Models.Contact
        {
            Name = ContactControl.Name,
            Email = ContactControl.Email,
            Phone = ContactControl.Phone,
            Address = ContactControl.Address,
        });

        Shell.Current.GoToAsync($"//{nameof(ContactPage)}");
    }

    private void ContactControl_OnCancel(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(ContactPage)}");
    }

    private void ContactControl_OnError(object sender, string e)
    {
        DisplayAlert("Error", e, "close");
    }
}