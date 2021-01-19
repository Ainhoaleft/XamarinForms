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
    public partial class Master : ContentPage
    {
        // Es MasterDetalle quien inicializa estas propiedades
        public DatosPage DatosPage { get; set; }
        public ConfiguracionPage ConfiguracionPage { get; set; }

        public Master()
        {
            InitializeComponent();

        }

        private void OnDatosTapped(object sender, EventArgs e)
        {
        
            // Navegamos a la página en cuestión
            ((MasterDetailPage)Parent).Detail = new NavigationPage(DatosPage);
            ((MasterDetailPage)Parent).IsPresented = false;
        }

        private void OnConfiguracionTapped(object sender, EventArgs e)
        {
            // Navegamos a la página en cuestión
            ((MasterDetailPage)Parent).Detail = new NavigationPage(ConfiguracionPage);
            ((MasterDetailPage)Parent).IsPresented = false;
        }
    }
}