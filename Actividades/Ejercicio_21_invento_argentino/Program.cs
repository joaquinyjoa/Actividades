using System;

namespace Ejercicio_21_invento_argentino
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            // Mostrar estado inicial
            Console.WriteLine($"Bolígrafo Azul - Tinta: {boligrafoAzul.GetTinta()}");
            Console.WriteLine($"Bolígrafo Rojo - Tinta: {boligrafoRojo.GetTinta()}");

            // Pintar con el bolígrafo azul
            Console.ForegroundColor = boligrafoAzul.GetColor();
            string dibujoAzul = boligrafoAzul.Pintar(10);
            Console.WriteLine($"Dibujo Azul: {dibujoAzul}");
            Console.ResetColor();

            // Pintar con el bolígrafo rojo
            Console.ForegroundColor = boligrafoRojo.GetColor();
            string dibujoRojo = boligrafoRojo.Pintar(20);
            Console.WriteLine($"Dibujo Rojo: {dibujoRojo}");
            Console.ResetColor();

            // Recargar tinta del bolígrafo rojo
            boligrafoRojo.Recarcar();
            Console.WriteLine($"Bolígrafo Rojo después de recargar - Tinta: {boligrafoRojo.GetTinta()}");
        }
    }
}
