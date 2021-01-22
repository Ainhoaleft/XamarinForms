using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejemplo4
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Destino> Destinos { get; set; } = new ObservableCollection<Destino>();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            Destinos.Add(new Destino() { Nombre = "Japón", Descripcion = "En Japón trabajan demasiado", Imagen="japon.jpg" });
            Destinos.Add(new Destino() { Nombre = "Marruecos", Descripcion = "Cocinan muy bien", Imagen = "marruecos.jpg" });
 
        }

        private void OnAnyadir(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Anyadir() { Destinos = this.Destinos});
        }

    }
}
