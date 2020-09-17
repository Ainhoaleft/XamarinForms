using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPares(object sender, EventArgs e)
        {
            int num1, num2;
            // Convertimos los dos números
            bool ok1 = Int32.TryParse(eNum1.Text, out num1);
            bool ok2 = Int32.TryParse(eNum2.Text, out num2);

            if ( ok1 && ok2)
            {
                // Los dos números son válidos
                /* En num1 debería estar el número pequeño y en num2 el número grande,
                 * vamos a comprobar que realmente es así, si no, los giraremos*/
                if(num1 > num2)
                {
                    // Hay que girarlos.
                    int aux = num1; // Guardamos en una variable auxiliar el valor de num1
                    num1 = num2; // Guardamos en num1 el valor de num2
                    num2 = aux; // Guardamos en num2 el valor que tenemos en aux
                }

                // Borramos el texto del label
                lPares.Text = "";

                // Llegados a este punto estamos seguros que num1 es más pequeño que num2
                /* Hacemos un bucle for para obtener los pares que hay entre num1 y num2 
                 * y los vamos añadiendo al label*/
                for (int i = num1; i<=num2; i++)
                {
                    if(i%2 == 0) // El operador % calcula el resto de una división, si el resto de dividir el número entre 2 es 0 significa que el número es par
                    {
                        lPares.Text += i + " "; // Con el operador += vamos concatenando texto al final del String (se va añadiendo)
                    }
                }
            } else
            {
                DisplayAlert("Error", "Los números son inválidos", "Cerrar");
            }
        }
    }
}
