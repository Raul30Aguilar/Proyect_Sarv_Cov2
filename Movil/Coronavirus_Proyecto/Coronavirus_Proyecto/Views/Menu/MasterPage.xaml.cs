using Coronavirus_Proyecto.Views.Forms;
using Coronavirus_Proyecto.Views.Noticias;
using Coronavirus_Proyecto.Views.Triaje;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Coronavirus_Proyecto.Class;
using System.ComponentModel;

namespace Coronavirus_Proyecto.Views.Menu
{
    /// <summary>
    /// Page to show article master page
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage
    {
        public GeoLocation _Geolocation = new GeoLocation();

        /// <summary>
        /// Initializes a new instance of the <see cref="MasterPage" /> class.
        /// </summary>
        public MasterPage()
        {
            InitializeComponent();
            configMap();
            moveToActualPosition();

        }


        private async void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Prueba());
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ArticleTilePage());
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new BusinessRegistrationFormPage());
        }
        void configMap()
        {
            mapa.UiSettings.CompassEnabled = true;
            mapa.UiSettings.MyLocationButtonEnabled = true;
            mapa.UiSettings.MapToolbarEnabled = true;
            mapa.MyLocationEnabled = true;
            mapa.FlowDirection = FlowDirection.LeftToRight;
            mapa.MapType = MapType.Street;
        }
        void moveToActualPosition()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await _Geolocation.getLocationGPS();
                Position _position = new Position(GeoLocation.lat, GeoLocation.lng);
 
                mapa.MoveToRegion(MapSpan.FromCenterAndRadius(_position, Distance.FromMeters(500)), true);

            });
        }

    }

}