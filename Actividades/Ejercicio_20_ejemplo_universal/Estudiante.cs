using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20_ejemplo_universal
{
    public class Estudiante
    {
        private string nombre;
        private string apellido;
        private int legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        /// <summary>
        /// utilizacion de una sola vez la instaciacion
        /// </summary>
        static Estudiante() 
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        /// <summary>
        /// verificamos si las notas con mayores o iguales a la nota minima
        /// </summary>
        /// <returns>La nota final para ver si aprobo o no</returns>
        public double CalcularNotaFinal()
        {
            int notaFinal = -1;
            if (notaPrimerParcial >= 4 && notaSegundoParcial >=4)
            {
                notaFinal = random.Next(6, 10);
            }
            return notaFinal;
        }
        /// <summary>
        /// Indicamos el promedio del estudiante 
        /// </summary>
        /// <returns>Su nota final promediada</returns>
        private float CalcularNotaPromedio() 
        {
            int notaFinal;
            notaFinal = notaPrimerParcial + notaSegundoParcial / 2;
            return notaFinal;
        }

        public void SetNotaPrimerParcial(int nota) 
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        public string Mostrar() 
        {
            float promedio = CalcularNotaPromedio();
            double notaFinal = CalcularNotaFinal();
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"{this.nombre}, {this.apellido}, {this.legajo}");
            mensaje.AppendLine($"Primer parcial: {this.notaPrimerParcial}");
            mensaje.AppendLine($"Segundo parcial: {this.notaSegundoParcial}");
            mensaje.AppendLine($"Promedio: {promedio}");
            if (notaFinal != -1)
            {
                mensaje.AppendLine($"Nota final: {notaFinal}");
            }
            else 
            {
                mensaje.AppendLine($"Alumno desaprobado");
            }

            return mensaje.ToString();
        }
    }
}
