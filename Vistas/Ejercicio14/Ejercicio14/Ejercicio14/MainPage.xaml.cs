using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio14
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAnyadir(object sender, EventArgs e)
        {
            StackLayout sl = new StackLayout();
            Random r = new Random();

            Label l1 = new Label();
            l1.Text = "Label 1";
            l1.BackgroundColor = Color.FromRgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            l1.HorizontalOptions = LayoutOptions.FillAndExpand;
            l1.FontSize = 30;

            Label l2 = new Label();
            l2.Text = "Label 2";
            l2.BackgroundColor = Color.FromRgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            l2.HorizontalOptions = LayoutOptions.FillAndExpand;
            l2.FontSize = 30;
             
            sl.Orientation = StackOrientation.Horizontal;

            sl.Children.Add(l1);
            sl.Children.Add(l2);

            slPrincipal.Children.Add(sl);
        }
    }
}
