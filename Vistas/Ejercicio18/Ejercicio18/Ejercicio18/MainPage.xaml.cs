using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio18
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Random r = new Random();
            b.BackgroundColor = Color.FromRgb(r.Next(256), r.Next(256), r.Next(256));
        }
    }
}
