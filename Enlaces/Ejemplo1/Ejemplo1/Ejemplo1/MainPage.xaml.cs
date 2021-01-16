using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejemplo1
{
    public partial class MainPage : ContentPage
    {
        private List<Pelicula> peliculas = new List<Pelicula>();
        private Pelicula p = new Pelicula();
        public MainPage()
        {
            InitializeComponent();
            // Al BindingContext asignamos una película
            BindingContext = p;
        }

        private void OnMostrar(object sender, EventArgs e)
        {
            // Mostramos el título y descripción de la película
            // Nos sirve para comprobar que el valor de las propiedades es el texto
            // Que hemos escrito en los entries.
            DisplayAlert(p.Titulo, p.Descripcion, "Cerrar");
        }

        private void OnGuardar(object sender, EventArgs e)
        {
            // Guardamos la película actual en la lista
            peliculas.Add(p);
            // Creamos una nueva película y la asignamos al entry
            p = new Pelicula();
            BindingContext = p;
        }
    }
}
