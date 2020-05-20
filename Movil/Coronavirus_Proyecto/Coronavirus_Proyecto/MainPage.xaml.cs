using Coronavirus_Proyecto.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Coronavirus_Proyecto
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjQzNjkxQDMxMzgyZTMxMmUzMGZOMFJQbTl1TG1vQ05OY3BGajdqSDNkUkJueGl5cUxMdzJOSVhDMHBxUFU9");


            InitializeComponent();

            btnEntendido.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new BusinessRegistrationFormPage());   
            };
        }
    }
}
