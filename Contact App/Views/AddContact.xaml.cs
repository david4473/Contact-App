namespace Contact_App.Views;

public partial class AddContact : ContentPage
{
	public AddContact()
	{
		InitializeComponent();
	}

    private void btn3_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}