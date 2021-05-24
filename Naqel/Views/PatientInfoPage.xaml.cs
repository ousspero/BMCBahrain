using BMSBahrain.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMSBahrain.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PatientInfoPage : ContentPage
    {
        public PatientInfoPage()
        {
            InitializeComponent();
            BindingContext = new PatientInfoViewModel();
        }


    }
}