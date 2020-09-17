using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnTextoModificado(object sender, TextChangedEventArgs e)
        {
            // Copiamos el texto
            lTexto.Text = eTexto.Text;
            // En función de la longitud del texto cambiamos el color
            if(lTexto.Text.Length < 5 || lTexto.Text.Length > 10)
            {
                // Si la longitud del texto es inferior a 5 o superior a 10 cambiamos el color del texto a rojo
                lTexto.TextColor = Color.FromHex("FF0000");
            } else
            {
                // En caso contrario el texto será negro
                lTexto.TextColor = Color.Black;
            }
        }
    }
}
