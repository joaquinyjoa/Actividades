using Ejercicio_12_calculadora;
internal class Program
{
    private static void Main(string[] args)
    {
        bool finalizacion = true;
        int primerNumero;
        int segundoNumero;
        string operacion;
        int resultado;
        string decision;


        while (finalizacion)
        {
            Console.Write("Deseas ingresar a la calculador? (s/n): ");
            decision = Console.ReadLine();
            if (decision == "s")
            {
                Console.Write("Ingrese el primer operador: ");
                primerNumero = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nIngrese el seguindo operador: ");
                segundoNumero = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nIngrese la operacion (ingresando el caracter +, -, * o /): ");
                operacion = Console.ReadLine();

                resultado = Calculadora.Calcular(primerNumero, segundoNumero, operacion);

                Console.Write($"Resultado = {resultado}");
                Console.WriteLine();
            }
            else
            {
                finalizacion = false;
            }

        }
    }
}