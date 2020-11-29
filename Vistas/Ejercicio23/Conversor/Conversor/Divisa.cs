using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor
{
    class Divisa
    {
        public TipoDivisa TipoDivisa { get; }

        private static List<String> nombres = new List<String>(){
            "Euro €",
            "Dolar $",
            "Libra £"
        };

        public Divisa (TipoDivisa tipoDivisa)
        {
            TipoDivisa = tipoDivisa;
        }
        public override string ToString()
        {
            return nombres[(int)TipoDivisa];
        }
    }
}
