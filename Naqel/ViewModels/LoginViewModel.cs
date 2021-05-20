using BMSBahrain.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BMSBahrain.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command RegisterCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            RegisterCommand = new Command(OnRegisterClicked);
        }

        private async void OnRegisterClicked(object obj)
        {
            await App.Current.MainPage.Navigation.PushAsync( new RegisterPage());
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            AppShell shell = new AppShell();
            //shell.FlowDirection = FlowDirection.RightToLeft;
            //MainPage = shell;
            App.Current.MainPage = shell;
            //await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
