using Coronavirus_Proyecto.Views.Forms;
using Coronavirus_Proyecto.Views.Menu;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Coronavirus_Proyecto.Views.Onboarding
{
    /// <summary>
    /// Page to display on-boarding gradient with animation
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnBoardingAnimationPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnBoardingAnimationPage" /> class.
        /// </summary>
        public OnBoardingAnimationPage()
        {
            InitializeComponent();

            NextButtonText.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new MasterPage());
            };
        }
    }
}