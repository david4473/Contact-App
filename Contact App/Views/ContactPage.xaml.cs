using Contact_App.Models;
using System.Collections.ObjectModel;
using Contact = Contact_App.Models.Contact;

namespace Contact_App.Views;

public partial class ContactPage : ContentPage
{
    public ContactPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var ContactList = new ObservableCollection<Contact>(ContactRepository.GetAllContacts());
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

    private void btnAddContact_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContact));
    }
}