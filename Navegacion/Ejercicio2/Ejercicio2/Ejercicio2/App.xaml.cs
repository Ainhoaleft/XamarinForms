using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // RECORDAD QUE PARA UTILIZAR LA NAVEGACIÓN JERÁRQUICA
            // ES NECESARIO QUE EL MAIN PAGE SEA UN NAVIGATION PAGE
            MainPage = new NavigationPage(new MainPage());
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
