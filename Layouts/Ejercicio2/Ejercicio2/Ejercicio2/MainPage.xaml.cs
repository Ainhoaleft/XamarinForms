using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AnyadirClicked(object sender, EventArgs e)
        {
            Label l = new Label();
            l.Text = eTitulo.Text;
            l.FontSize = 24;
            slPeliculas.Children.Add(l);
        }

        private void CambiarClicked(object sender, EventArgs e)
        {
            foreach(View v in slPeliculas.Children)
            {
                Label l = (Label)v;
                l.FontSize = Convert.ToInt32(eTamanyo.Text);
            }
        }
    }
}
