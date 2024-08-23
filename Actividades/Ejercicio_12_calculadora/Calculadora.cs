using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12_calculadora
{
    public class Calculadora
    {
        public static int Calcular(int primerOperador, int segundoOperador, string operacion) 
        {
            bool validarPorCero;
            int resultado = 0;
            if (operacion == "+")
            {
                resultado = primerOperador + segundoOperador;
            }
            else if(operacion == "-")
            {
                resultado = primerOperador - segundoOperador;
            }
            else if (operacion == "*")
            {
                resultado = primerOperador * segundoOperador;
            }
            else if (operacion == "/")
            {
                validarPorCero = Calculadora.Validar(segundoOperador);
                if (validarPorCero)
                {
                    resultado = primerOperador / segundoOperador;
                }
  
            }
            return resultado;
        }

        private static bool Validar(int segundoOperador) 
        {
            bool validarDivision = true;
            if (segundoOperador == 0)
            {
                validarDivision = false;
            }
            return validarDivision;
        }
    }
}
