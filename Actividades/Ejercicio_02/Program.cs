internal class Program
{
    private static void Main(string[] args)
    {
        //inicializar las varibles
        double numero;
        double cuadrado;
        double cubo;
        Console.Title = "Ejercicio_02";
        Console.WriteLine("Ejercicio A.02 Potencias");
        Console.Write("Ingrese cualquier numero: ");
        //obtenemos el dato
        numero = Convert.ToDouble(Console.ReadLine());

        //Verificar que no sea negativo
        if (numero < 0)
        {
            Console.Write("ERROR");
        }
        else
        {
            //mensaje
            cuadrado = Math.Pow(2, numero);
            Console.WriteLine("El numero elevado al cuadrado es: {0}", cuadrado);
            cubo = Math.Pow(3, numero);
            Console.WriteLine("El numero elevado al cuadrado es: {0}", cubo);
        }
        
    }
}