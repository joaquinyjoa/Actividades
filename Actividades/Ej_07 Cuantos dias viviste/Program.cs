using System.Diagnostics;
using System.Runtime.Serialization;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        int dia;
        int mes;
        int año;
        long diasVividos;

        DateTime fechaActual = DateTime.Now;
        Console.Write("Ingresa tu año de nacimiento: ");
        año = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Ingresa tu mes de nacimiento: ");
        mes = Convert.ToInt32(Console.ReadLine());
        if (mes > 12)
        {
            Console.Write($"ERROR.El año no tiene {mes} meses ");
        }
        else
        {
            Console.Write("Ingresa tu dia de nacimiento: ");
            dia = Convert.ToInt32(Console.ReadLine());

            if (año % 4 == 0)
            {
                Console.WriteLine($"tu año de nacimiento es bisiesto.");
            }
            if (año % 400 == 0)
            {
                Console.WriteLine($"tu año de nacimiento es bisiesto.");
            }
            else if (año % 100 == 0)
            {
                Console.WriteLine($"tu año de nacimiento no es bisiesto.");
            }

            DateTime nacimiento = new DateTime(año, mes, dia);
            TimeSpan diferencia = fechaActual.Subtract(nacimiento);
            diasVividos = diferencia.Days;

            Console.WriteLine($"Los días que has vivido hasta la fecha son: {diasVividos}");
        }

       
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}