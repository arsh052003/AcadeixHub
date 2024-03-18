using MauiApp3.ViewModels;
using MyLoginApp.ViewModels;

namespace MauiApp3;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel loginPageViewModel)
	{
		InitializeComponent();
		this.BindingContext = loginPageViewModel;
	}
}