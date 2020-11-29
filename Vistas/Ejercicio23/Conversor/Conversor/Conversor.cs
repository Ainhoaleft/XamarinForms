using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor
{
    enum TipoDivisa
    {
        EURO,
        DOLAR,
        LIBRA
    }
    class Conversor
    {
        private static Dictionary<TipoDivisa, Dictionary<TipoDivisa, double>> conversiones = new Dictionary<TipoDivisa, Dictionary<TipoDivisa, double>>()
        {
            { TipoDivisa.EURO, new Dictionary<TipoDivisa, double>() {
                    { TipoDivisa.LIBRA, 0.7},
                    { TipoDivisa.DOLAR, 1.1}
                }
            },

            { TipoDivisa.DOLAR, new Dictionary<TipoDivisa, double>() {
                    { TipoDivisa.LIBRA, 0.7}
                }
            }
        };
        public static bool Convertir(TipoDivisa tipoOrigen, TipoDivisa tipoDestino, double cantidad, out double res)
        {
            res = cantidad;
            bool ok = true;
            if(tipoOrigen != tipoDestino)
            {
                if (conversiones.ContainsKey(tipoOrigen))
                {
                    res *= conversiones[tipoOrigen][tipoDestino];
                } else
                {
                    if (conversiones.ContainsKey(tipoDestino))
                    {
                        res /= conversiones[tipoDestino][tipoOrigen];
                    } else
                    {
                        ok = false;
                    }
                }

            }

            return ok;
        }

    }
}
