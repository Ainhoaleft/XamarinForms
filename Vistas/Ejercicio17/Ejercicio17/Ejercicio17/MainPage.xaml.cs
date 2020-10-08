using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio17
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void RojoChanged(object sender, CheckedChangedEventArgs e)
        {
            // Método que se ejecuta cuando se pulsa sobre el checkbox rojo
            // Cuando se ejecuta este método en principio no sabemos si se ejecuta porque se ha activado el checkbox o se ha desactivado
            // Como primer parámetro recibimos el objeto (vista) que ha producido el evento, en este caso el checkbox, por eso podemos hacer un cast o conversión
            // para convertir el object a un CheckBox.

            CheckBox cb = (CheckBox)sender;

            // Una vez tenemos el checkbox podemos consultar si está activo o no, y en función de eso mostrar u ocultar el label correspondiente.
            if (cb.IsChecked)
            {
                lbRojo.IsVisible = true;
            }
            else
            {
                lbRojo.IsVisible = false;
            }
        }

        private void AzulChanged(object sender, CheckedChangedEventArgs e)
        {
            // Método que se ejecuta cuando se pulsa sobre el checkbox azul
            CheckBox cb = (CheckBox)sender;
            if (cb.IsChecked)
            {
                lbAzul.IsVisible = true;
            }
            else
            {
                lbAzul.IsVisible = false;
            }
        }

        private void VerdeChanged(object sender, CheckedChangedEventArgs e)
        {

            // Método que se ejecuta cuando se pulsa sobre el checkbox verde
            // Otra forma de saber si el checkbox está activo o desactivado lo podemos saber a través del parámetro e y su propiedad Value, que nos indicará si el checkbox está activo o no
            // Cualquiera de las dos formas presentadas es válida para consultar si el checkbox está activo o no.
            if (e.Value)
            {
                lbVerde.IsVisible = true;
            }
            else
            {
                lbVerde.IsVisible = false;
            }
        }

    }
}
