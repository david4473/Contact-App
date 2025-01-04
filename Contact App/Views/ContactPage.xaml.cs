namespace Contact_App.Views;

public partial class ContactPage : ContentPage
{
    public ContactPage()
    {
        InitializeComponent();

        List<Contact> ContactList = new List<Contact>() 
        {
            new Contact {Name = "Frog", Email = "man@gmail.com"},
            new Contact {Name = "Lion", Email = "man@gmail.com"},
            new Contact {Name = "Egg", Email = "man@gmail.com"},
            new Contact {Name = "Pork", Email = "man@gmail.com"}
        };

        ListContacts.ItemsSource = ContactList;
    }

    public class Contact
    {
        public required String Name {get; set;}
        public required String Email { get; set; }
    }

    private void ListContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        DisplayAlert("Test", $"{ListContacts.SelectedItem}", "Done");
    }
}