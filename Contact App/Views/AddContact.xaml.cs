namespace Contact_App.Views;

public partial class AddContact : ContentPage
{
	public AddContact()
	{
		InitializeComponent();
	}

    private void ContactControl_OnSave(object sender, EventArgs e)
    {

    }

    private void ContactControl_OnCancel(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void ContactControl_OnError(object sender, string e) 
    {

    }
}