using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio NRO 01";
        Console.WriteLine("[A.01] Máximos, mínimos y promedios");

        int numero;
        int minimo;
        int maximo;
        int suma = 0;
        int promedio;
        int ingreso = 5;

        // Ingresar el primer número
        Console.Write("Ingresa cualquier número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        // Inicializar mínimo, máximo y suma con el primer número
        minimo = numero;
        maximo = numero;
        suma += numero;

        // Ingresar los siguientes números
        for (int i = 1; i < ingreso; i++)
        {
            Console.Write("Ingresa cualquier número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            suma += numero;

            // Actualizar el máximo
            if (numero > maximo)
            {
                maximo = numero;
            }

            // Actualizar el mínimo
            if (numero < minimo)
            {
                minimo = numero;
            }
        }

        Console.WriteLine("\nValor mínimo: " + minimo);
        Console.WriteLine("Valor máximo: " + maximo);
        promedio = suma / ingreso;
        Console.WriteLine("Promedio: " + promedio);
    }
}
