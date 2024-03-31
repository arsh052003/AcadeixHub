using MauiApp3.Models;
using MauiApp3.ViewModels;
using MauiApp3.Views.Homepage;

namespace MauiApp3
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            this.BindingContext = new AppShellViewModel();
            //Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        }
    }
}
