using Contact_App.Models;
using Contact = Contact_App.Models.Contact;

namespace Contact_App.Views;

public partial class ContactPage : ContentPage
{
    public ContactPage()
    {
        InitializeComponent();

        List<Contact> ContactList = ContactRepository.GetAllContacts();

        ListContacts.ItemsSource = ContactList;
    }

    private async void ListContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (ListContacts.SelectedItem != null)
        {
            await Shell.Current.GoToAsync($"{nameof(EditContact)}?Id={((Contact)ListContacts.SelectedItem).ContactId}");
        }
    }

    private void ListContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        ListContacts.SelectedItem = null;
    }
}