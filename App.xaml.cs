using MauiApp3.Models;

namespace MauiApp3
{
    public partial class App : Application
    {
        public static UserInfo UserInfo;
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }
    }
}
