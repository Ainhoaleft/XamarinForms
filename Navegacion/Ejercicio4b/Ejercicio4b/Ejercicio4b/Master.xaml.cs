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
    public partial class Master : ContentPage
    {
        Configuracion configuracion = new Configuracion();
        public Master()
        {
            InitializeComponent();

        }

        private void OnDatosTapped(object sender, EventArgs e)
        {
            // Navegamos a la página en cuestión
            ((MasterDetailPage)Parent).Detail = new NavigationPage(new DatosPage(configuracion));
            ((MasterDetailPage)Parent).IsPresented = false;
        }

        private void OnConfiguracionTapped(object sender, EventArgs e)
        {
            // Navegamos a la página en cuestión
            ((MasterDetailPage)Parent).Detail = new NavigationPage(new ConfiguracionPage(configuracion));
            ((MasterDetailPage)Parent).IsPresented = false;
        }
    }
}