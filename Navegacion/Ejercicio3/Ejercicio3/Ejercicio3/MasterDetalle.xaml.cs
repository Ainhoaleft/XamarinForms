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
    public partial class MasterDetalle : MasterDetailPage
    {
        public MasterDetalle()
        {
            InitializeComponent();
        }
    }
}