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

        private void OnPulsar(object sender, EventArgs e)
        {
            /* Al pulsar el botón el texto del entry lo guardamos 
             * en la propiedad Text del label.*/
            eSalida.Text = eEntrada.Text;
        }
    }
}
