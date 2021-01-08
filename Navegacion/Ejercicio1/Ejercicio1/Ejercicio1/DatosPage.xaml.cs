using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatosPage : ContentPage
    {
        public DatosPage(DatosRegistro DatosRegistro)
        {
            InitializeComponent();
            lNombre.Text = DatosRegistro.Nombre;
            lEmail.Text = DatosRegistro.Email;
            lContrasenya.Text = DatosRegistro.Contrasenya;

        }
    }
}