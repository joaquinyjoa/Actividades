using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14_tabla_multiplicar
{
    public class Tabla
    {
        public static string Multiplicar(int numero) 
        {
            int multiplicacion;
            StringBuilder cadena = new StringBuilder();
            for (int i = 1; i <= 10; i++)
            {
                multiplicacion = i * numero;
                cadena.AppendLine($"{numero} * {i} = {multiplicacion}");
            }

            return cadena.ToString();
        }
    }
}
