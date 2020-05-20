using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Coronavirus_Proyecto.Views.Triaje;

namespace Coronavirus_Proyecto.Views.Forms
{
    /// <summary>
    /// Page to add business details such as name, email address, and phone number.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BusinessRegistrationFormPage : ContentPage 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessRegistrationFormPage" /> class.
        /// </summary>
        public BusinessRegistrationFormPage()
        {
            InitializeComponent();


            btnContinuar.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new PersonaTriaje());
            };
        }
    }
}
