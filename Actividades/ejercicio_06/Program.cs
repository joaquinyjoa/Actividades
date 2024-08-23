internal class Program
{
    private static void Main(string[] args)
    {
        //inicializar variables
        int inicio;
        int fin;

        //entrada
        Console.Write("Ingrese un año de inicio: ");
        inicio = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el año de fin: ");
        fin = Convert.ToInt32(Console.ReadLine());

        for (int i = inicio; i <= fin; i++)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine($"El año {i} es bisiesto.");
            }
            if (i % 400 == 0)
            {
                Console.WriteLine($"El año {i} es bisiesto.");
            }
            else if (i % 100 == 0)
            {
                Console.WriteLine($"El año {i} no es bisiesto.");
            }

        }
    }
}