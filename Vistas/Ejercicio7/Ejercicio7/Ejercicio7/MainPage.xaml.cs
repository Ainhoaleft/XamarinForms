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
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPulsado(object sender, EventArgs e)
        {
            int cantidad;
            bool ok = Int32.TryParse(eCantidad.Text, out cantidad);
            if (ok)
            {
                for(int i = 0; i<cantidad; i++)
                {
                    Label l = new Label();
                    l.Text = eTexto.Text;
                    slMiLayout.Children.Add(l);
                }
            }
        }
    }
}
