using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio4b
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

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
