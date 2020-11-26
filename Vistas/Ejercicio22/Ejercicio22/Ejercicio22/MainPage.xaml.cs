using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio22
{
    public partial class MainPage : ContentPage
    {
        List<Articulo> articulos = new List<Articulo>()
            {
                new Articulo("Libreta", 7.95, 10),
                new Articulo("Bolígrafo", 1.95, 12),
                new Articulo("Borrador", 2.50, 25),
                new Articulo("Mochila", 29.95, 5),
                new Articulo("Calculadora", 19.95, 7),
                new Articulo("Lapiz", 1.00, 12),

            };

        public MainPage()
        {
            
            InitializeComponent();
            lArticulos.ItemsSource = articulos;
        }

        private void Buscar(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(ePrecio.Text))
            {
                lArticulos.ItemsSource = articulos;
            } else
            {
                // Haciendo uso de LINQ
                lArticulos.ItemsSource = articulos.Where(a => a.Precio < Convert.ToDouble(ePrecio.Text));
            }
        }

        private void ElementoSeleccionado(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                Articulo a = (Articulo)e.SelectedItem;
                DisplayAlert(a.Descripcion, "Precio: " + a.Precio + "\nStock: " + a.Stock, "Cerrar");
                lArticulos.SelectedItem = null;
            }
        }
    }
}
