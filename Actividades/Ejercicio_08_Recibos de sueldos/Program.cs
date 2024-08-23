internal class Program
{
    private static void Main(string[] args)
    {
        int hora;
        string nombre;
        int antiguedad;
        int cantidadHoras = 1;
        int empleados;
        int importeTotal;
        double importeDescueto;
        double importeNeto;
        double descuento = 0.13;

        Console.Write("Ingrese cantidad de empleados: ");
        empleados = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < empleados; i++)
        {
            Console.Write("Ingrese nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write($"Ingrese cantidad de horas de {nombre}: ");
            hora = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Ingrese la antiguedad de {nombre}: ");
            antiguedad = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Ingrese la cantidad total de horas trabajadas de {nombre}: ");
            cantidadHoras = Convert.ToInt32(Console.ReadLine());
            importeTotal =  (cantidadHoras * hora) + (antiguedad * 15000);
            importeDescueto = importeTotal * descuento;
            importeNeto = importeTotal - importeDescueto;

            Console.WriteLine();

            Console.WriteLine($"Nombre : {nombre}");
            Console.WriteLine($"Antiguedad : {antiguedad}");
            Console.WriteLine($"Hora trabajadas : {hora}");
            Console.WriteLine($"Valor bruto : {importeTotal}$");
            Console.WriteLine($"Total del descuento : {importeDescueto}$");
            Console.WriteLine($"Total del valor neto : {importeNeto}$");

        }

    }
}