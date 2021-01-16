using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        Usuario usuario;
        public Page1(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void OnGuardar(object sender, EventArgs e)
        {
            usuario.Nombre = eNombre.Text;
        }
    }
}