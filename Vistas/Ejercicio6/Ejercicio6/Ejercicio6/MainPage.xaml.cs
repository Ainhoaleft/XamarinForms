using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnEscribe(object sender, TextChangedEventArgs e)
        {
            int tamanyo;
            // Convertimos el texto escrito en número
            bool ok = Int32.TryParse(eTamanyoFuente.Text, out tamanyo);
            if (ok)
            {
                // Si ha ido bien asignamos el valor al tamaño de la fuente
                lHola.FontSize = tamanyo;
            }
        }
    }
}
