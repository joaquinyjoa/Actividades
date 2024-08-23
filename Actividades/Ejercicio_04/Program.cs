internal class Program
{
    private static void Main(string[] args)
    {
        int contadorPerfectos = 0;
        int numero = 1;

        while (contadorPerfectos < 4) // Encontrar los primeros 4 números perfectos
        {
            double suma = 0;

            for (int i = 1; i < numero; i++) // Encontrar los divisores de "numero"
            {
                if (numero % i == 0) // Si "i" es un divisor de "numero"
                {
                    suma += i; // Sumar el divisor a la suma
                }
            }

            if (suma == numero) // Verificar si la suma de los divisores es igual al número
            {
                Console.WriteLine($"{numero} es un número perfecto.");
                contadorPerfectos++; // Incrementar el contador de números perfectos encontrados
            }

            numero++; // Incrementar el número para probar el siguiente
        }
    }

}