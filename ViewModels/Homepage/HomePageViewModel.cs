using MauiApp3.Controls;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.ViewModels.Homepage
{
    public partial class HomePageViewModel : BaseViewModel
    {
        public HomePageViewModel()
        {
            AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();
        }

    }
}
