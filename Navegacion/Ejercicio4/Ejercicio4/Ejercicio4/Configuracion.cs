using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Ejercicio4
{
    /* Clase configuración con los parámetros de configuración.
     * Utilizaremos una instancia de esta clase para "pasar" la información entre las páginas */

    public class Configuracion
    {
        public static List<TextColor> Colores = new List<TextColor>
        {
            new TextColor("Negro", Color.Black),
            new TextColor("Rojo", Color.Red),
            new TextColor("Azul", Color.Blue)
        };

        public int TamanyoFuente { get; set; }
        public TextColor ColorFuente { get; set; }
        public bool Negrita { get; set; }

        public Configuracion()
        {
            // Configuración por defecto
            TamanyoFuente = 32;
            ColorFuente = Colores[0];
            Negrita = false;
        }
    }
}
