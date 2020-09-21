using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio9
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Creamos el primer label
            Label l1 = new Label();
            l1.BackgroundColor = Color.Red;
            l1.FontSize = 40;
            l1.Text = "Ejercicio 9";
            // El texto está centrado
            l1.HorizontalTextAlignment = TextAlignment.Center;
            // Añadimos el label al stacklayout
            slMiLayout.Children.Add(l1);

            // Creamos el segundo label
            Label l2 = new Label();
            l2.BackgroundColor = Color.Blue;
            l2.FontSize = 40;
            l2.Text = "Label";
            // El elemento debe estar centrado horizontalmente
            l2.HorizontalOptions = LayoutOptions.Center;
            // Pero también debe estarlo verticalmente, para ello añadimos la cláusula AndExpand
            l2.VerticalOptions = LayoutOptions.CenterAndExpand;
            // Añadimos el label al stacklayout
            slMiLayout.Children.Add(l2);

            Button b = new Button();
            b.Text = "BOTON";
            b.FontSize = 40;
            // El botón está alineazo a la izquierda (End)
            b.HorizontalOptions = LayoutOptions.End;
            // Añadimos el botón al stacklayout
            slMiLayout.Children.Add(b);
        }
    }
}
