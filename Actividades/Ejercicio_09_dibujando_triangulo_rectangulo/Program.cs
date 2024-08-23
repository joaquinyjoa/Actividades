/*
 [A.09] Dibujando un triángulo rectángulo
Escribir un programa que imprima por pantalla una pirámide como la siguiente:
*
***
*****
*******
*********

El usuario indicará cuál será la altura de la pirámide ingresando un número entero
positivo. Para el ejemplo anterior la altura ingresada fue de 5.
Nota: Utilizar estructuras repetitivas y selectivas.
 */

internal class Program
{
    private static void Main(string[] args)
    {
        int valor_altura;
        int ancho = 1; 

        Console.Write("Ingrese altura de la piramide(numero positivo): ");
        valor_altura = Convert.ToInt32(Console.ReadLine());
        while (valor_altura <= 0)
        {
            Console.Write("Ingrese altura de la piramide(numero positivo): ");
            valor_altura = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < valor_altura; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            ancho++;
        }

    }
}