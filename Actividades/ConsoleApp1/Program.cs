using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int digitos = 0;

        if (x < 0)
        {
            Console.WriteLine("(Advertencia: es un numero negativo)");
            x = -x;
        }

        while (x > 0)
        {
            x /= 10;
            digitos++;
        }

        if (digitos == 0)
        {
            digitos = 1;
        }

        Console.WriteLine("{0} dÃ­gitos", digitos);

        /*
         * RANGO DE TABLAS
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        double multiplicacion;
        for (int i = x; i <= y; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                multiplicacion = i * j;
                Console.WriteLine($"{i} X {j} = {multiplicacion}");
            }
            Console.WriteLine();
        }
        */

        /*
         * DIVISION Y RESTO
        int primer_numero = Convert.ToInt32(Console.ReadLine());
        int segundo_numero = Convert.ToInt32(Console.ReadLine());
        double division;
        double resto;

        if (segundo_numero == 0)
        {
            Console.Write("No se puede dividir por 0");
        }
        else
        {
            division = primer_numero / segundo_numero;
            resto = primer_numero % segundo_numero;
            Console.WriteLine(division);
            Console.WriteLine(resto);
        }
        */

        /*  CONTROL DE ACCESO */
        /*int intentos = 3;
        for (int i = 0; i < 1; i++)
        {
            string nombre = Console.ReadLine();
            int contraseña = Convert.ToInt32(Console.ReadLine());
            if (nombre != "admin" || contraseña != 1234)
            {
                intentos--;
            }

            if (intentos <= 0)
            {
                break;
            }
        }

        if (intentos != 0)
        {
            Console.Write("INICIO DE SESION");
        }
        else
        {
            Console.Write("ERROR");
        }
        */
        /*
         * MUESTRA LOS MULTIPLOS DE 3 Y DE 5
         * for (int i = 1; i <= 500; i++)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
            {
                Console.Write($"{i} ");
            }
        }*/

        /*
        string nombre = Console.ReadLine();
        int j = 1;
        for (int i = nombre.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(nombre.Substring(i, j));
            j++;
        }
        */

        /*
        //entrada e inicializacion
        int alto = Convert.ToInt32(Console.ReadLine());
        int ancho = 0;
        int max = alto;

        for (int fila = 0; fila < alto; fila++)
        {
            //espacio a dejar
            for (int columna = 0; columna < ancho; columna++)
            {
                Console.Write(" ");
            }
            //los simbolos creados
            for (int simbolos = 0; simbolos < max; simbolos++)
            {
                Console.Write("*");
            }
            //salto de linea
            Console.WriteLine();
            //y aca el ancho aumenta por el alto
            ancho++;
            //aca se van corriendo a la derecha
            max--;
        }*/
    }
}