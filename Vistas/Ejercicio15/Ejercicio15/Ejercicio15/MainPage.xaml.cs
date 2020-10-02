using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio15
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnImagen1(object sender, EventArgs e)
        {
            iMiImagen.Source = "img1.jpg";
        }

        private void OnImagen2(object sender, EventArgs e)
        {
            iMiImagen.Source = "img2.jpg";
        }

        private void OnImagen3(object sender, EventArgs e)
        {
            iMiImagen.Source = "img3.jpg";
        }
    }
}
