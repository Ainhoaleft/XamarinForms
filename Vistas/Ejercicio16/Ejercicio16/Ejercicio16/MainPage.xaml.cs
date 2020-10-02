using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio16
{
    public partial class MainPage : ContentPage
    {

        // Un array de string para almacenar las imagenes disponibles en la carpeta Resources >  drawable del proyecto Ejercicio5.Android
        private String[] imagenes = {
            "paisaje.jpg",
            "paisaje2.jpg",
            "paisaje3.jpg"
        };

        // pos es una variable que nos sirve para indicar qué imagen se va a mostrar (posición del array)
        private int pos = 0;

        public MainPage()
        {
            InitializeComponent();
            // Mostramos la imagen que tenemos en la posición 0 del array de imagenes
            miImagen.Source = imagenes[pos];
        }

        private void Anterior(object sender, EventArgs e)
        {
            pos--;
            // Comprobamos que la posición no sea inferior a 0 para no salirnos del array, si es así, pos pasará a ser la última posición del array (damos la vuelta)
            if (pos < 0)
                pos = imagenes.Length - 1;

            miImagen.Source = imagenes[pos];
        }

        private void Siguiente(object sender, EventArgs e)
        {
            pos++;
            // Comprobamos que la posición no es mayor que las posiciones disponibles en el array, si es así, pos pasará a ser 0 (damos la vuelta)
            if (pos == imagenes.Length)
                pos = 0;

            miImagen.Source = imagenes[pos];
        }
    }
}
