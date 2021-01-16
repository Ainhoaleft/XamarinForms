using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Ejercicio7
{
    class Usuario : INotifyPropertyChanged
    {
        private string nombre;
        public string Nombre { 
            get
            {
                return nombre;
            }

            set
            {
                // Cuando se modifica el valor del nombre ...
                nombre = value;
                // Notificamos del cambio de la propiedad
                NotifyPropertyChanged("Nombre");
                // Esto sirve para notificar a la interfaz y que así se actualice el label
            }
        }

        // Método que lanza el evento PropertyChanged
        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

       
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
