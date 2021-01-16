using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public int Anyo { get; set; }
        public string Nacionalidad { get; set; }
        public string Descripcion { get; set; }
        public string Cartel { get; set; }


        public List<string> Actores { get; set; } = new List<string>();

        public override string ToString()
        {
            return Titulo + " - " + Anyo;
        }
    }
}
