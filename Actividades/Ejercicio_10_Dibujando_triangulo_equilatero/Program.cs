internal class Program
{
    private static void Main(string[] args)
    {
        int valor_alto;
        Console.Write("Ingrese el alto de la piramide: ");
        valor_alto = Convert.ToInt32(Console.ReadLine());

        int ancho_separacion = valor_alto - 1;  // Inicialmente la separación es alto-1
        int asterisco = 1;  // Comenzamos con un asterisco en la primera fila

        for (int i = 0; i < valor_alto; i++)
        {
            // Imprimir los espacios antes de los asteriscos
            for (int j = 0; j < ancho_separacion; j++)
            {
                Console.Write(" ");
            }

            // Imprimir los asteriscos
            for (int j = 0; j < asterisco; j++)
            {
                Console.Write("*");
            }

            // Mover a la siguiente línea
            Console.WriteLine();

            // Disminuir el número de espacios y aumentar el número de asteriscos
            ancho_separacion--;
            asterisco += 2;  // Aumentar los asteriscos en 2 para la siguiente fila
        }
    }
}
