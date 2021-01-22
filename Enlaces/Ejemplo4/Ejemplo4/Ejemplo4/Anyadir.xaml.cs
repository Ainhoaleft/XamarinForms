using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejemplo4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anyadir : ContentPage
    {
        Destino d = new Destino();
        public ObservableCollection<Destino> Destinos { get; set; } = new ObservableCollection<Destino>();
        public Anyadir()
        {
            InitializeComponent();
            BindingContext = d;
        }

        private void Guardar(object sender, EventArgs e)
        {
            // Validar que las entradas son válida
            // Si todos los datos introducidos son correctos
            // Añadimos el destino d a destinos
            Destinos.Add(d);
            Navigation.PopAsync();
        }
    }
}