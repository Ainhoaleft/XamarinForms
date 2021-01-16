using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public int Anyo { get; set; }
        public string Nacionalidad { get; set; }
        public string Descripcion { get; set; }
        public string Cartel { get; set; }
        // OJO! SI NO ES UNA PROPIEDAD NO SE PUEDE HACER BINDINGS
        // Con esta línea no funciona:
        //public List<string> Actores = new List<string>();
        // Con esta sí:
        public List<string> Actores { get; set; } = new List<string>();
        public override string ToString()
        {
            return Titulo + " - " + Anyo;
        }
    }
}
