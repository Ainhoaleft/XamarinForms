using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio21
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnModificar(object sender, EventArgs e)
        {
            foreach(StackLayout sl in slLabels.Children)
            {
                CheckBox cb = (CheckBox) sl.Children[0];
                if (cb.IsChecked)
                {
                    Label l = (Label) sl.Children[1];
                    l.Text = eTexto.Text;
                }
            }
        }

        private void OnAnyadir(object sender, EventArgs e)
        {
            CheckBox cb = new CheckBox();
            Label l = new Label();
            l.Text = "Label";
            l.VerticalOptions = LayoutOptions.Center;
            l.FontSize = 30;

            StackLayout sl = new StackLayout();
            sl.Orientation = StackOrientation.Horizontal;

            sl.Children.Add(cb);
            sl.Children.Add(l);

            slLabels.Children.Add(sl);
        }

    }
}
