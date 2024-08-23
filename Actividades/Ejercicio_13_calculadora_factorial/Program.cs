using Ejercicio_13_calcular_factorial;
internal class Program
{
    private static void Main(string[] args)
    {
        int numeroIngresado;
        int resultado;

        Console.Write("Ingrese el numero para factorizar :");
        numeroIngresado = Convert.ToInt32(Console.ReadLine());
        resultado = CalculadoraFactorial.Calcular(numeroIngresado);

        Console.Write(resultado);
    }
}