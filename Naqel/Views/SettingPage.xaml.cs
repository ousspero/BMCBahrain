using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMSBahrain.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is Picker)
            {
                string lang = ((Picker)sender).SelectedItem.ToString();
                switch (lang)
                {
                    case "English":
                        CultureInfo.CurrentUICulture = new CultureInfo("en-US");
                        break;
                    case "Français":
                        CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");
                        break;
                    case "العربية":
                        CultureInfo.CurrentUICulture = new CultureInfo("ar-SA");
                        break;
                    default: break;
                }
                FlowDirection = CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;
                App.Current.MainPage = new AppShell();
                App.Current.MainPage.FlowDirection = FlowDirection;
            }

        }
    }
}