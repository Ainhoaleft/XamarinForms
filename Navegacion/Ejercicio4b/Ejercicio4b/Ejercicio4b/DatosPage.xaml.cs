using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio4b
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatosPage : ContentPage
    {
        Configuracion configuracion;
        public DatosPage()
        {
            InitializeComponent();
        }
        public DatosPage(Configuracion configuracion)
        {
            InitializeComponent();
            this.configuracion = configuracion;
            if (configuracion != null)
            {
                lDatos.TextColor = configuracion.ColorFuente.Color;
                lDatos.FontSize = configuracion.TamanyoFuente;
                if (configuracion.Negrita)
                    lDatos.FontAttributes = FontAttributes.Bold;
            }
        }

    }
}