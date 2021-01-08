using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRegistrarse(object sender, EventArgs e)
        {
            DatosRegistro dr = new DatosRegistro()
            {
                Nombre = eNombre.Text,
                Email = eEmail.Text,
                Contrasenya = eContrasenya.Text
            };
            DatosPage dp = new DatosPage(dr);
            Navigation.PushAsync(dp);
        }
    }
}
