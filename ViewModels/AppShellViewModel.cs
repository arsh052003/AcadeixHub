using MauiApp3.Views.Startup;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.ViewModels
{
    public partial class AppShellViewModel :BaseViewModel
    {
        [ICommand]
        async void SignOut()
        {
           
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
