using Contact_App.Views;

namespace Contact_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ContactPage), typeof(ContactPage));
            Routing.RegisterRoute(nameof(EditContact), typeof(EditContact));
            Routing.RegisterRoute(nameof(AddContact), typeof(AddContact));

        }
    }
}
