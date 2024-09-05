using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_21_prueba_geometrica;
using Ejercicio_22_prueba_geometrica;

namespace Ejercicio_22_prueba_geometrica
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float GetArea() 
        {
            return this.area;
        }

        public float GetPerimetro()
        {
            return this.perimetro;
        }

        public float Area()
        {
            double baseLength = Math.Abs(vertice2.GetX() - vertice1.GetX());
            double altura = Math.Abs(Vertice4.Y - Vertice1.Y);
            return area;
        }

        public float Perimetro() 
        {
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());;
        }
    }
}
