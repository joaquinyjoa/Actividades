using Ejercicio_19_cuantas_primaveras;
internal class Program
{
    private static void Main(string[] args)
    {
        Persona personaUno = new Persona("Juan",new DateTime(1800,12,10),46013501);
        Persona personaDos = new Persona("Julieta", new DateTime(2015, 05, 06), 35012520);
        Persona personaTres = new Persona("Agustin", new DateTime(2000, 12, 10), 14632584);

        Console.WriteLine(personaUno.Mostrar());
        Console.WriteLine(personaDos.Mostrar());
        Console.WriteLine(personaTres.Mostrar());

        if (personaUno.EsMayorEdad())
        {
            Console.WriteLine($"{personaUno.GetNombre()} es mayor de edad");
        }
        else
        {
            Console.WriteLine($"{personaUno.GetNombre()} es menor de edad");
        }

        if (personaDos.EsMayorEdad())
        {
            Console.WriteLine($"{personaDos.GetNombre()} es mayor de edad");
        }
        else
        {
            Console.WriteLine($"{personaDos.GetNombre()} es menor de edad");
        }

        if (personaTres.EsMayorEdad())
        {
            Console.WriteLine($"{personaTres.GetNombre()} es mayor de edad");
        }
        else
        {
            Console.WriteLine($"{personaTres.GetNombre()} es menor de edad");
        }
    }
}