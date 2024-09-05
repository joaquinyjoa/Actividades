using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17_tiempo
{
    public class FechaActual
    {
        public static string CalcularFechaActual(DateTime cumpleaños) 
        {
            int diasRestantes;
            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia;

            StringBuilder mensaje = new StringBuilder();

            diferencia = fechaActual - cumpleaños;
            diasRestantes = diferencia.Days;
            mensaje.Append($"La diferencia de dias con la fecha actual es: {diasRestantes}");

            return mensaje.ToString();
        }
    }
}
