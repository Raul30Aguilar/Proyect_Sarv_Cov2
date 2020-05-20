using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
namespace Coronavirus_Proyecto.Class
{
    class NetworkState
    {

        public static bool isConnect = false;

        //se obtiene el estado de la red



        public void iHaveInternet()
        {
            NetworkAccess current = Connectivity.NetworkAccess;
            determineState(current);
            //se detecta el cambio de la red

            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;

        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {

            determineState(e.NetworkAccess);

           }

        //se determina el estado de la red y su metodo
        public void determineState(NetworkAccess state)
        {
            if(state == NetworkAccess.Internet)
            {
                isConnect = true;
            }
            else if (state == NetworkAccess.Local)
            {
                isConnect = true;
            }
            else if (state == NetworkAccess.ConstrainedInternet)
            {
                isConnect = false;
            }
            else
            {
                isConnect = false;
            }
        }
    }
}
