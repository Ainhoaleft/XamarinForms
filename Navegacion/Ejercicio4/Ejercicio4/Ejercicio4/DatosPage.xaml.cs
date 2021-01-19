using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatosPage : ContentPage
    {
        public Configuracion Configuracion { get; set; }
        public DatosPage()
        {
            InitializeComponent();
            ActualizaLabel();
        }

        protected override void OnAppearing()
        {
            ActualizaLabel();
        }

        private void ActualizaLabel()
        {
            if (Configuracion != null)
            {
                lDatos.TextColor = Configuracion.ColorFuente.Color;
                lDatos.FontSize = Configuracion.TamanyoFuente;
                if (Configuracion.Negrita)
                    lDatos.FontAttributes = FontAttributes.Bold;
            }
        }
    }
}