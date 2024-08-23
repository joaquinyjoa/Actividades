using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13_calcular_factorial
{
    public class CalculadoraFactorial
    {
        public static int Calcular(int numero) 
        {
            int resta;
            resta = numero - 1;
            if (numero != 1)
            {
                for (int i = resta; i > 0; i--)
                {
                    numero *= i;
                }
            }

            return numero;
        }
    }
}
