using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio2
{
    public partial class MainPage : ContentPage
    {
        /* Esta variable nos servirá para saber si el label muestra
         * el texto "Hola" (la variable estará a true) o si
         * el label muestra el text "Mundo" (la variable estará a false).
         */
        bool hola = true;
        public MainPage()
        {
            InitializeComponent();
        }


        private void OnCambia(object sender, EventArgs e)
        {
            // Si pulsamos el botón y se está mostrando el texto "Hola"
            // Es decir, si hola es true
            if(hola)
            {
                // Lo cambiamos a "Mundo"
                lTitulo.Text = "Mundo";
                // Con el booleano hola indicamos que estamos mostrando mundo
                hola = false;
            } else
            {
                // Si hola es false, significa que estamos mostrando el texto "Mundo"
                // por lo que pasaremos a mostrar el texto "Hola"
                lTitulo.Text = "Hola";
                hola = true;
            }
        }
    }
}
