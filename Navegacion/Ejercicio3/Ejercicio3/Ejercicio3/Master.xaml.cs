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
    public partial class Master : ContentPage
    {
        Usuario usuario = new Usuario();
        public Master()
        {
            InitializeComponent();
        }

        private void OnPagina1(object sender, EventArgs e)
        {
            ((MasterDetalle)Parent).Detail = new NavigationPage(new Page1(usuario));
            ((MasterDetalle)Parent).IsPresented = false;
        }

        private void OnPagina2(object sender, EventArgs e)
        {
            ((MasterDetalle)Parent).Detail = new NavigationPage(new Page2(usuario));
            ((MasterDetalle)Parent).IsPresented = false;
        }
    }
}