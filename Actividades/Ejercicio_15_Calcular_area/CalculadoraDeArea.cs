using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15_Calcular_area
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double area;
            area = Math.Pow(longitudLado, 2);
            return area;
        }

        public static double CalcularAreaTriangulo(double basee, double altura) 
        {
            double area;
            area = (basee * altura) / 2;
            return area;
        }

        /// <summary>
        /// Calculamos el area del circulo con el valor ingresado
        /// </summary>
        /// <param name="radio">Radio del circulo</param>
        /// <returns></returns>
        public static double CalcularAreaCirculo(double radio) 
        {
            double area;
            double pi = 3.14;
            area = pi * Math.Pow(radio,2);
            return area;
        }
    }
}
