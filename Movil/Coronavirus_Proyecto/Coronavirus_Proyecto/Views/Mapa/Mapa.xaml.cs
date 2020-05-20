using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Coronavirus_Proyecto.Class;
using System.ComponentModel;

namespace Coronavirus_Proyecto.Views.Mapa
{

    [DesignTimeVisible(false)]
    public partial class Mapa : ContentPage
    {
        public GeoLocation _Geolocation = new GeoLocation();

        public Mapa()
        {  
            InitializeComponent();
            configMap();
            moveToActualPosition();
          
        } 

        //configuracion del mapa 

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
            Device.BeginInvokeOnMainThread(async() =>
            {
                await _Geolocation.getLocationGPS();
                Position _position = new Position(GeoLocation.lat,GeoLocation.lng);
                //lat.Text = GeoLocation.lat.ToString();
                //lng.Text = GeoLocation.lng.ToString();
                mapa.MoveToRegion(MapSpan.FromCenterAndRadius(_position, Distance.FromMeters(500)), true);

            });
        }
        void showStateNetwork()
        {
            //state.Text = NetworkState.isConnect.ToString();

        }
    }
}