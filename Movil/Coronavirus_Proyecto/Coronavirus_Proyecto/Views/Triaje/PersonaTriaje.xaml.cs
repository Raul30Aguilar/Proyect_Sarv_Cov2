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
    public partial class PersonaTriaje : ContentPage
    {
        public PersonaTriaje()
        {
            InitializeComponent();
            btnContinuar1.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new PersonaTriaje1());
            };
        }
    }
}