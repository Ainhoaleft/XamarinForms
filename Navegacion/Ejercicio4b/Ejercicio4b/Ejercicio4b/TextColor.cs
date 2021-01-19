using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Ejercicio4b
{
    public class TextColor
    {
        public string Nombre { get; set; }
        public Color Color { get; set; }

        public TextColor(String Nombre, Color Color)
        {
            this.Nombre = Nombre;
            this.Color = Color;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
