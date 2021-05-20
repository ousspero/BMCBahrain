using BMSBahrain.Resx;
using BMSBahrain.ViewModels;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMSBahrain.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel();
        }

    }
}