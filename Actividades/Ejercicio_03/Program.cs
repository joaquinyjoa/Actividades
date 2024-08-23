using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //inicializamos las variables
        double numero;
        Console.WriteLine("Ingrese un número: ");
        numero = double.Parse(Console.ReadLine());

        for (int i = 2; i <= numero; i++)
        {
            bool esPrimo = true;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    esPrimo = false;
                    break; // Si encontramos un divisor, no es primo
                }
            }

            if (esPrimo)
            {
                Console.WriteLine(i);
            }
        }
    }
}