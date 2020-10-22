using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio20
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAdd(object sender, EventArgs e)
        {
            /* Crear aleatoriamente el color, para ello obtenemos aleatoriamente
             * un número del 0 al 2 (inclusive). El 0 será para el rojo, el 1 para el verde
             * y el 2  para el azul */

            Random r = new Random();
            int num = r.Next(0, 3);

            // Creamos el label
            Label l = new Label();
            l.FontSize = 30;
            
            // Asignamos los colores y el texto correspondiente
            switch (num)
            {
                case 0:
                    l.BackgroundColor = Color.Red;
                    l.Text = "Red";
                    break;
                case 1:
                    l.BackgroundColor = Color.Green;
                    l.Text = "Green";
                    break;
                default:
                    l.BackgroundColor = Color.Blue;
                    l.Text = "Blue";
                    break;
            }
            slLabels.Children.Add(l);
        }

        private void OnBorrar(object sender, EventArgs e)
        {
            /* Existen múltiples maneras de resolver el borrado
             * A continuación se muestran ejemplos que se basan en iterar
             * por los diferentes labels y comprobar si color de fondo y los checkbox
             * activos.*/

            /* OPCIÓN 1 */

            /* for(int i = slLabels.Children.Count-1; i >= 0 ; i--)
            {
                Label l = (Label)slLabels.Children[i];

                if (cbRed.IsChecked && l.BackgroundColor == Color.Red)
                {
                        slLabels.Children.RemoveAt(i);
                }
                if (cbBlue.IsChecked && l.BackgroundColor == Color.Blue)
                {
                        slLabels.Children.RemoveAt(i);
                }
                if (cbGreen.IsChecked && l.BackgroundColor == Color.Green)
                {
                        slLabels.Children.RemoveAt(i);
                }
            }*/

            /* OPCIÓN 2 */
            /*for (int i = slLabels.Children.Count - 1; i >= 0; i--)
            {
                Label l = (Label)slLabels.Children[i];

                if (cbRed.IsChecked && l.BackgroundColor == Color.Red)
                {
                    slLabels.Children.Remove(l);
                }
                if (cbBlue.IsChecked && l.BackgroundColor == Color.Blue)
                {
                    slLabels.Children.Remove(l);
                }
                if (cbGreen.IsChecked && l.BackgroundColor == Color.Green)
                {
                    slLabels.Children.Remove(l);
                }
            }*/

            /* OPCIÓN 3 */
            for (int i = slLabels.Children.Count - 1; i >= 0; i--)
            {
                Label l = (Label)slLabels.Children[i];

                if ((cbRed.IsChecked && l.BackgroundColor == Color.Red) ||
                    (cbBlue.IsChecked && l.BackgroundColor == Color.Blue) ||
                    (cbGreen.IsChecked && l.BackgroundColor == Color.Green))
                {
                    slLabels.Children.Remove(l);
                }
            }


        }
    }
}
