using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio6
{
    public partial class MainPage : ContentPage
    {
        Login login = new Login();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = login;
        }

        private void MostrarAlerta(object sender, EventArgs e)
        {
            DisplayAlert("Login", login.UserName, "Cerrar");
        }
    }
}
