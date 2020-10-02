using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio13
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSuma(object sender, EventArgs e)
        {
            RealizaOperacion(1);
        }

        private void OnResta(object sender, EventArgs e)
        {
            RealizaOperacion(2);
        }

        private void OnMultiplicacion(object sender, EventArgs e)
        {
            RealizaOperacion(3);
        }

        private void OnDivision(object sender, EventArgs e)
        {
            RealizaOperacion(4);
        }

        /* Se ha creado el método RealizaOperacion para no tener el código repetido en los métodos
         * OnSuma, OnResta, OnMultiplicacion y OnDivision*/
        private void RealizaOperacion(int operacion)
        {

            int o1, o2, res = 0;

            // Comprobamos que podemos convertir el valor introducido en los entries a enteros
            bool ok1 = Int32.TryParse(eOperando1.Text, out o1);
            bool ok2 = Int32.TryParse(eOperando2.Text, out o2);

            // No se pueden hacer divisiones por 0, por lo que vamos a comprobar que no sea el caso
            if (operacion == 4 && ok2)
            {
                /* Si la operación es 4 (división) y hemos podido convertir el segundo operando (ok2 es true), 
                 * comprobamos que el operando 2 (o2) no sea 0.
                 * Si es 0 diremos que el operando 2 no es correcto, es deci, ok2 = false; */
                if (o2 == 0)
                {
                    ok2 = false;
                }
            }
            if (ok1 && ok2)
            {
                /* Si las dos conversiones han ido bien y no estamos intentando hacer una división por 0,
                entonces en o1 y en o2 tenemos los dos números*/
                // Realizamos la operación correspondiente y guardamos el resultado en res.
                switch (operacion)
                {
                    case 1:
                        res = o1 + o2;
                        break;
                    case 2:
                        res = o1 - o2;
                        break;
                    case 3:
                        res = o1 * o2;
                        break;
                    case 4:
                        res = o1 / o2;
                        break;
                    default:
                        break;
                }
                /* Mostramos el resultado en el label. No podemos hacer directamente:
                 * lResultado.Text = res;
                 * ya que la propiedad Text espera un String y res es un entero,
                 * por eso hay que concatenar la variable res con la cadena vacía.
                 */
                lResultado.Text = "" + res;
            }
            else
            {
                /* Mostramos un mensaje de error con DisplayAlert.
                 * El primer parámetro es el título que se mostrará en al alerta.
                 * El segundo el mensaje que se mostrará.
                 * El último es el texto que aparecerá en el botón para cerrar la alerta*/
                DisplayAlert("Error", "Alguno de los operandos no son válidos", "Cerrar");
            }
        }
    }
}
