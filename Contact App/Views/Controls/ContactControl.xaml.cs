namespace Contact_App.Views.Controls;

public partial class ContactControl : ContentView
{
    public event EventHandler<String> OnError;
    public event EventHandler<EventArgs> OnSave;
    public event EventHandler<EventArgs> OnCancel;

	public ContactControl()
	{
		InitializeComponent();
	}

    public String Name 
    {
        get
        {
            return entryName.Text;
        } 
       set
        {
            entryName.Text = value;
        }
    }
    public String Email 
    {
        get 
        {
            return entryEmail.Text;
        }
        set
        {
            entryEmail.Text = value;
        } 
    }
    public String Phone 
    {
        get
        {
            return entryPhone.Text;
        } 
        set
        {
            entryPhone.Text = value;
        }
    }
    public String Address 
    { 
        get
        {
            return entryAddress.Text;
        }
        set
        {
            entryAddress.Text = value;
        } 
    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        if (nameValidator.IsNotValid)
        {
            OnError?.Invoke(sender, "Name cannot be empty");
            return;
        }

        if (emailValidator.IsNotValid)
        {
            foreach (var error in emailValidator.Errors)
            {
                OnError?.Invoke(sender, error.ToString());
            }

            return;
        }

        OnSave?.Invoke(sender,e);
    }

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        OnCancel?.Invoke(sender, e);
    }
}