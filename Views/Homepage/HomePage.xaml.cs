using MauiApp3.ViewModels.Homepage;

namespace MauiApp3.Views.Homepage;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}