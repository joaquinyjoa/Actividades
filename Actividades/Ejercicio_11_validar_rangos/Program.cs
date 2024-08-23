using Ejercicio_11_validar_rangos;

internal class Program
{
    private static void Main(string[] args)
    {
        double valorIngresado;
        double minimo = 0;
        double maximo = 0;
        double promedio;
        double suma = 0;
        bool validarNumero;
        bool bandera_max = true;
        bool bandera_min = true;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese un numero estre -100 y 100: ");
            valorIngresado = Convert.ToInt32(Console.ReadLine());
            validarNumero = Validador.Validar(valorIngresado, -100, 100);
              
            if (validarNumero == false)
            {
                i--;
            }

            if (valorIngresado < minimo || bandera_min == true)
            {
                minimo = valorIngresado;
                bandera_min = false;

            }
            if (valorIngresado > maximo || bandera_max == true)
            {
                maximo = valorIngresado;
                bandera_max = false;
            }

            suma += valorIngresado;
        }

        promedio = suma / 10;

        Console.WriteLine($"Valor minimo: {minimo}");
        Console.WriteLine($"Valor maximo: {maximo}");
        Console.WriteLine($"Promedio: {promedio}");
    }

}