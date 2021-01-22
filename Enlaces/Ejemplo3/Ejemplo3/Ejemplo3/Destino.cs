using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo3
{
    public class Destino
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
