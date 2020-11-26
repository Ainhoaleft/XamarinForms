using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio22
{
    class Articulo
    {
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public Articulo(string descripcion, double precio, int stock)
        {
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Stock = stock;
        }
        public override string ToString()
        {
            return Descripcion + " " + Precio + "€";
        }
    }
}
