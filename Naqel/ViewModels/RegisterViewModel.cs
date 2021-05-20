using BMSBahrain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BMSBahrain.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public ICommand RegiserCommand { get; set; }
        public RegisterModel Model { get => _model; set => SetProperty(ref _model, value); }

        private RegisterModel _model;
        public RegisterViewModel()
        {
            Model = new RegisterModel();
            RegiserCommand = new Command(OnRegiserCommandClicked);

        }

        private void OnRegiserCommandClicked(object obj)
        {
            var xxx = Model;
        }
    }
}
