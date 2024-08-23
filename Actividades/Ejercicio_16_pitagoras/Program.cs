using Ejercicio_16_pitagoras;
public class Program
{
    private static void Main(string[] args)
    {
        double basee;
        double altura;
        string hipotenusa;

        Console.Write("Ingrese la base del triangulo: ");
        basee = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura del tringulo: ");
        altura = Convert.ToDouble(Console.ReadLine());
        hipotenusa = CalculadoraHipotenusa.CalcularHipotenusa(basee, altura);
        Console.Write(hipotenusa);
    }
}