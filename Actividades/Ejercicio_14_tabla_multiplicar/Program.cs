using Ejercicio_14_tabla_multiplicar;
internal class Program
{
    private static void Main(string[] args)
    {
        int numeroIngresado;
        string tabla;

        Console.Write("Ingresa el numero a multiplicar:");
        numeroIngresado = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Tabla de multiplicar del {numeroIngresado}");
        tabla = Tabla.Multiplicar(numeroIngresado);
        Console.Write(tabla);
    }
}