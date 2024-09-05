using Ejercicio_20_ejemplo_universal;
internal class Program
{
    private static void Main(string[] args)
    {
        string nombre;
        string apellido;
        int legajo;
        int notaPrimerParcial;
        int notaSegundoParcial;
        //creacion de las instancias
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Ingrese nombre del estudiante: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el apellido del estudiante: ");
            apellido = Console.ReadLine();
            Console.Write("Ingrese legajo del estudiante: ");
            legajo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la nota del primer parcial: ");
            notaPrimerParcial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la nota del segundo parcial: ");
            notaSegundoParcial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Estudiante estudiante = new Estudiante(nombre, apellido, legajo);
            estudiante.SetNotaPrimerParcial(notaPrimerParcial);
            estudiante.SetNotaSegundoParcial(notaSegundoParcial);
            Console.Write(estudiante.Mostrar());
            Console.WriteLine();
        }
    }
}