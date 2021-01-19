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
    public partial class MasterDetalle : MasterDetailPage
    {
        // Objeto configuración que será utilizado por ambas páginas
        Configuracion configuracion = new Configuracion(); 

        public MasterDetalle()
        {
            InitializeComponent();
        }
    }
}