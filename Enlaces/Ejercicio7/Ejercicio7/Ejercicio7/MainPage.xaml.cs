using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio7
{
    public partial class MainPage : ContentPage
    {
        Usuario u = new Usuario();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = u;
        }

        private void OnAlerta(object sender, EventArgs e)
        {
            DisplayAlert("Nombre", u.Nombre, "Cerrar");
        }
    }
}
