using BMSBahrain.Services;
using BMSBahrain.Views;
using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMSBahrain
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            //DependencyService.Register<MockDataStore>();
            //CultureInfo.CurrentUICulture = new CultureInfo("ar-SA");
            //NavigationPage navigation = new NavigationPage(new LoginPage());
            //navigation.BackgroundColor = (Color)this.Resources["Primary"];

            //MainPage = navigation;
            //MainPage.FlowDirection = CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;

            MainPage = new PatientInfoPage();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
