using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16_pitagoras
{
    public class CalculadoraHipotenusa
    {
        public static string CalcularHipotenusa (double basee, double altura)
        {
            double resultado;
            double hipotenusa;
            StringBuilder mensaje = new StringBuilder ();
            resultado = Math.Pow (basee, 2) + Math.Pow(altura, 2);
            hipotenusa = Math.Sqrt (resultado);
            mensaje.Append($"la hipotenusa del triangulo es: {hipotenusa}");
            return mensaje.ToString();
        }
    }
}
