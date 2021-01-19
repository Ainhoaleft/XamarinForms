using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio4b
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfiguracionPage : ContentPage
    {

        Configuracion configuracion;
        public ConfiguracionPage(Configuracion configuracion)
        {
            InitializeComponent();
            this.configuracion = configuracion;

            // Añadimos los elementos al picker.
            List<TextColor> colores = new List<TextColor>();
            pColores.ItemsSource = Configuracion.Colores;
            // Por defecto seleccionamos el primero
            pColores.SelectedIndex = 0;
        }

        private void GuardarClicked(object sender, EventArgs e)
        {
            // Al pulsar guardar, se guarda la configuración en la propiedad Configuración
            configuracion.ColorFuente = ((TextColor)pColores.SelectedItem);
            configuracion.TamanyoFuente = (int) sFuente.Value;
            configuracion.Negrita = cbNegrita.IsChecked;
        }

    }
}