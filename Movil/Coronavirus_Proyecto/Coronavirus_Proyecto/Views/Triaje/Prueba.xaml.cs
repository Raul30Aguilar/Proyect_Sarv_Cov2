using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coronavirus_Proyecto.Views.Triaje
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Prueba : ContentPage
    {
        private void Browser_Navigated(object sender, WebNavigatedEventArgs e)
        {
            LoadingLabel.IsVisible = false;

        }


        private void Browser_Navigating(object sender, WebNavigatingEventArgs e)
        {
            LoadingLabel.IsVisible = true;
        }
     
        void Go_Clicked(object sender, EventArgs e)
        {
            Browser.Source= "https://app.powerbi.com/view?r=eyJrIjoiOWIwNmVlZTctNTYzMy00Y2IyLTljMGUtOTA4ZmQ5NWMyNTcwIiwidCI6Ijc5MDVjMWZjLTkzM2MtNDUyYS04YjgzLWIyZTU2NDU1ZDE2YSIsImMiOjR9";

        }

        void Fordward_Clicked(object sender, EventArgs e)
        {
            if (Browser.CanGoForward)
                Browser.GoForward();
        }


        void Back_Clicked(object sender, EventArgs e)
        {
            if (Browser.CanGoBack)
                Browser.GoBack();
        }
        public Prueba()
        {
            InitializeComponent(); 
            //url.Text = "https://app.powerbi.com/view?r=eyJrIjoiNGQ2MjA0NzktMTY2NC00NzJmLWE5NGUtODJiZTIwZmY1YzFkIiwidCI6Ijc5MDVjMWZjLTkzM2MtNDUyYS04YjgzLWIyZTU2NDU1ZDE2YSIsImMiOjR9";
            //Browser.Source = url.Text;

            Browser.Source= "https://app.powerbi.com/view?r=eyJrIjoiNGQ2MjA0NzktMTY2NC00NzJmLWE5NGUtODJiZTIwZmY1YzFkIiwidCI6Ijc5MDVjMWZjLTkzM2MtNDUyYS04YjgzLWIyZTU2NDU1ZDE2YSIsImMiOjR9";
        }


    }
}