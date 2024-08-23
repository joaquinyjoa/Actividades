using Ejercicio_15_Calcular_area;
internal class Program
{
    private static void Main(string[] args)
    {
        double triangulo;
        double circulo;
        double cuadrado;

        cuadrado = CalculadoraDeArea.CalcularAreaCuadrado(84);
        circulo = CalculadoraDeArea.CalcularAreaCirculo(3333);
        triangulo = CalculadoraDeArea.CalcularAreaTriangulo(3,4);

        Console.WriteLine(cuadrado);
        Console.WriteLine(circulo);
        Console.WriteLine(triangulo);
    }
}