using Ejercicio_17_tiempo;

internal class Program
{
    private static void Main(string[] args)
    {
        int dia;
        int mes;
        int año;
        string fecha;

        Console.Write("Ingrese su año de nacimiento :");
        año = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Ingrese su mes de nacimiento: ");
        mes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su dia de nacimiento: ");
        dia = Convert.ToInt32(Console.ReadLine());

        fecha = FechaActual.CalcularFechaActual(new DateTime(año,mes,dia));

        Console.Write(fecha);

        if (año % 4 == 0)
        {
            Console.WriteLine($"El año {año} es bisiesto.");
        }
        if (año % 400 == 0)
        {
            Console.WriteLine($"El año {año} es bisiesto.");
        }
        else if (año % 100 == 0)
        {
            Console.WriteLine($"El año {año} no es bisiesto.");
        }
    }
}