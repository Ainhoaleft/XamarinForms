using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio5
{
    public partial class MainPage : ContentPage
    {

        List<Pelicula> lPeliculas = new List<Pelicula>();
        public MainPage()
        {
            InitializeComponent();

            //Creamos las películas y las añadimos a la lista

            Pelicula p = new Pelicula()
            {
                Titulo = "Mad Max: Fury Road",
                Anyo = 2015,
                Nacionalidad = "Australia",
                Descripcion = "Max Rockatansky, el apodado Mad Max, " +
                "tiene que sobrevivir a un mundo posapocaliptico lleno de problemas. " +
                "En su largo viaje por los paramos, conoce a Imperator Furiosa, " +
                "en la que Max ve un reflejo de el mismo cuando era un hombre cuerdo.",
                Cartel = "MMFR"
            };
            p.Actores.Add("Tom Hardy");
            p.Actores.Add("Charlize Theron");

            lPeliculas.Add(p);

            p = new Pelicula()
            {
                Titulo = "Rambo V: Last Blood",
                Anyo = 2019,
                Nacionalidad = "Estados Unidos",
                Descripcion = "John Rambo luchara por ultima vez con sus " +
                "fantasmas del pasado, enfrentandose a un poderoso cartel de Mexico, " +
                "el cual a secuestrado a la que consideraba su hija y debe salvarla y darles su merecido.",
                Cartel = "RVLB"
            };
            p.Actores.Add("Sylvester Stallone");
            p.Actores.Add("Paz Vega");
            p.Actores.Add("Oscar Jaenada");
            p.Actores.Add("Sergio Peris-Mencheta");

            lPeliculas.Add(p);

            p = new Pelicula()
            {
                Titulo = "Los Mercenarios 2",
                Anyo = 2012,
                Nacionalidad = "Estados Unidos",
                Descripcion = "Barney Ross y su equipo de mercenarios se enzarzan " +
                "en una mision que a primera vista iba a ser sencilla, " +
                "pero los planes se complicaron y ahora, no solo tienen que terminar la mision, " +
                "si no que tienen que acabar con un equipo de terroristas " +
                "y vengar la tragica muerte de uno integrante del equipo ",
                Cartel = "LM2"
            };
            p.Actores.Add("Sylvester Stallone");
            p.Actores.Add("Jason Statham");
            p.Actores.Add("Arnold Schwarzenegger");
            p.Actores.Add("Jet Li");
            p.Actores.Add("Chuck Norris");
            p.Actores.Add("Jean-Claude Van Damme");
            p.Actores.Add("Bruce Willis");
            p.Actores.Add("Dolph Lundgren");
            p.Actores.Add("Terry Crews");

            lPeliculas.Add(p);

            /* Mostramos las películas en el List View.
             * Recordad que lo que el texto que se muestra en el List View es el devuelto
             * por el método ToString, en este caso de la clase Película */
            lvListaPeliculas.ItemsSource = lPeliculas;
        }

        // Este método se ejecuta cada vez que se muestra la página
        // Es decir, si estamos en el tabbed page y pulsamos atrás,
        // Se ejecutará este método:
        protected override void OnAppearing()
        {
            lvListaPeliculas.SelectedItem = null;
        }
        private void PeliculaSeleccionada(object sender, SelectedItemChangedEventArgs e)
        {
            // Para evitar problemas solo se ejecutará el código si el elemento seleccionado es diferente de null
            if (lvListaPeliculas.SelectedItem != null)
            {

                // Obtenemos la película seleccionada
                Pelicula peliculaSeleccionada = (Pelicula)lvListaPeliculas.SelectedItem;
                // También se puede hacer:
                //Pelicula peliculaSeleccionada = (Pelicula)e.SelectedItem;

                // Hacemos uso del BindingContext de la página para asignarle la película seleccionada
                TabbedPage1 tp = new TabbedPage1();
                tp.BindingContext = peliculaSeleccionada;
                Navigation.PushAsync(tp);

            }
        }
    }
}
