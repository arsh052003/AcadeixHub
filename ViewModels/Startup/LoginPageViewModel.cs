using MauiApp3.Models;
using MauiApp3.Views.Homepage;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.ViewModels.Startup
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _username;
        [ObservableProperty] 
        private string _password;
        #region Commands
        [ICommand]

        async void Login()
        {
            //Preferences.ContainsKey(nameof());
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }


    }
    #endregion
}
