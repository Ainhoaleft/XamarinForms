using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejemplo2
{
    public partial class MainPage : ContentPage
    {
        // El ObservableCollection es un tipo de colección que lanza un evento cada vez que se modifica la lista, por ejemplo, al añadir un elemento
        public ObservableCollection<Destino> Destinos { get; set; } = new ObservableCollection<Destino>();
        public MainPage()
        {
            InitializeComponent();
            // Indicamos que el Contexto es la propia instancia de MainPage que es donde se encuentra la propiedad Destinos.
            BindingContext = this;

            Destinos.Add(new Destino() { Nombre = "Japón", Descripcion = "En Japón trabajan demasiado", Imagen="japon.jpg" });
            Destinos.Add(new Destino() { Nombre = "Marruecos", Descripcion = "Cocinan muy bien", Imagen = "marruecos.jpg" });
 
        }

        private void OnAnyadir(object sender, EventArgs e)
        {
            // Añadimos un destino cada vez que pulsamos el botón
            // Podemos comprobar que el ListView se actualiza automáticamente gracias a utilizar el ObservableCollection
            Destinos.Add(new Destino() { Nombre = "Marruecos", Descripcion = "Cocinan muy bien", Imagen = "marruecos.jpg" });
        }

    }
}
