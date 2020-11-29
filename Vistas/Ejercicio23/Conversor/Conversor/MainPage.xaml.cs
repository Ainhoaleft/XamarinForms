using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Conversor
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Dictionary<string, string> clientes = new Dictionary<string, string>();
            clientes.Add("20000Q", "Pepito");
            clientes.Add("30000Q", "Juanito");

            string nombreCliente = clientes["20000Q"];







            List <Divisa> divisas = new List<Divisa>();
            divisas.Add(new Divisa(TipoDivisa.EURO));
            divisas.Add(new Divisa(TipoDivisa.DOLAR));
            divisas.Add(new Divisa(TipoDivisa.LIBRA));

            pkDivisaOrigen.ItemsSource = divisas;
            pkDivisaDestino.ItemsSource = divisas;

        }


        private void Convertir_Clicked(object sender, EventArgs e)
        {

            double res;
            Divisa divisaOrigen = (Divisa) pkDivisaOrigen.SelectedItem;
            Divisa divisaDestino = (Divisa)pkDivisaDestino.SelectedItem;
            double cantidad = Int32.Parse(eCantidad.Text);

            if (Conversor.Convertir(divisaOrigen.TipoDivisa, divisaDestino.TipoDivisa, cantidad, out res))
            {
                lbResultado.Text = "" + res;
            }
        }
    }
}
