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
    public partial class MasterDetalle : MasterDetailPage
    {
        // Objeto configuración que será utilizado por ambas páginas
        Configuracion configuracion = new Configuracion(); 

        public MasterDetalle()
        {
            InitializeComponent();
            // Asignamos la configuración a DatosPage
            ((DatosPage)((NavigationPage)Detail).RootPage).Configuracion = configuracion;

            //Guardamos en DatosPage de Master la página que estamos mostrando actualmmente en Detail.
            ((Master)Master).DatosPage = ((DatosPage)((NavigationPage)Detail).RootPage);

            // Creamos la página de configuración y le asignamos la configuración
            ConfiguracionPage cp = new ConfiguracionPage();
            cp.Configuracion = configuracion;

            //Guardamos en ConfiguracionPage de Master la página creada.
            ((Master)Master).ConfiguracionPage = cp;
        }
    }
}