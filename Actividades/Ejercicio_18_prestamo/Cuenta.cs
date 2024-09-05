using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18_prestamo
{
    public class Cuenta
    {
        public string titular;
        public decimal cantidad;

        public Cuenta(decimal cantidad, string titular) 
        {
            this.cantidad = cantidad;
            this.titular = titular;
        }

        public string GetTitular() 
        {
            return titular;
        }

        public decimal GetCantidad()
        {
            return cantidad;
        }

        public decimal Ingresar(decimal monto) 
        {
            decimal suma;

            if (monto < 1)
            {
                suma = 0;
            }
            else
            {
                suma = cantidad + monto;
            }

            return suma;
        }

        public decimal retirar(decimal monto) 
        {
            decimal extraccion;
            extraccion = cantidad - monto;

            return extraccion;
        }

        public string Mostrar() 
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"Razon del titular: {titular}");
            mensaje.Append($"Monto actual de la cuenta: {cantidad}");

            return mensaje.ToString();
        }
    }
}
