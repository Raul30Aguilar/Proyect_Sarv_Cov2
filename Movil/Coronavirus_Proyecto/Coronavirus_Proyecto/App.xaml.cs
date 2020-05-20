using Coronavirus_Proyecto.Views.Noticias;
using Coronavirus_Proyecto.Views.Onboarding;
using Coronavirus_Proyecto.Views.Triaje;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Coronavirus_Proyecto.Class;
using Coronavirus_Proyecto.Views.Mapa;
using Coronavirus_Proyecto.Views.Menu;

namespace Coronavirus_Proyecto
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
        public App()
        {
            InitializeComponent();
            //new GeoLocation().getLocationGPS(); 
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjQzNjkxQDMxMzgyZTMxMmUzMGZOMFJQbTl1TG1vQ05OY3BGajdqSDNkUkJueGl5cUxMdzJOSVhDMHBxUFU9");
            new NetworkState().iHaveInternet();
            MainPage = new NavigationPage(new OnBoardingAnimationPage());


        }

        protected override void OnStart()
        {
            //MainPage = new NavigationPage(new Mapa());
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
