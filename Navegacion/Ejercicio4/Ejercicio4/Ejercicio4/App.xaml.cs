using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // RECORDAD! INDICAMOS QUE LA PRIMERA PÁGINA, EN ESTE CASO, ES MASTER DETALLE
            MainPage = new MasterDetalle();
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
