using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11_validar_rangos
{
    public class Validador
    {
        public static bool Validar(double valor, double min, double max) 
        {
            bool validado = false;
            if (valor >= min && valor <= max)
            {
                validado = true;
            }

            return validado;
        }
    }
}
