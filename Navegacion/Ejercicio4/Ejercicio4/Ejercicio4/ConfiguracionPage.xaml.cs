using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfiguracionPage : ContentPage
    {

        public Configuracion Configuracion { get; set; }
        public ConfiguracionPage()
        {
            InitializeComponent();

            // Añadimos los elementos al picker.
            List<TextColor> colores = new List<TextColor>();
            pColores.ItemsSource = Configuracion.Colores;
            // Por defecto seleccionamos el primero
            pColores.SelectedIndex = 0;
        }

        private void GuardarClicked(object sender, EventArgs e)
        {
            // Al pulsar guardar, se guarda la configuración en la propiedad Configuración
            Configuracion.ColorFuente = ((TextColor)pColores.SelectedItem);
            Configuracion.TamanyoFuente = (int) sFuente.Value;
            Configuracion.Negrita = cbNegrita.IsChecked;
        }

        protected override void OnAppearing()
        {
            // Cada vez que se muestra la página se carga la configuración
            if (Configuracion != null)
            {
                sFuente.Value = Configuracion.TamanyoFuente;
                pColores.SelectedItem = Configuracion.ColorFuente;
                cbNegrita.IsChecked = Configuracion.Negrita;
            }
        }
    }
}