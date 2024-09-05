using Ejercicio_18_prestamo;
using System.Diagnostics;
internal class Program
{
    private static void Main(string[] args)
    {
        string titular;
        decimal monto;
        int opcion;
        Cuenta cuenta = new Cuenta(1000, "");
        bool bandera = true;
        Console.Write("Ingrese titular de la cuenta: ");
        titular = Console.ReadLine();

        while (bandera)
        {
            cuenta.titular = titular;
            //Datos de la cuenta y opciones
            Console.WriteLine(cuenta.Mostrar());
            Console.WriteLine("Ingrese una de las opciones: ");
            Console.WriteLine("1 - Ingresar monto ");
            Console.WriteLine("2 - Retirar monto ");
            Console.WriteLine("3 - Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
           
            switch (opcion) 
            {
                case 1:
                    //Aumenta el ingreso de la cuenta
                    Console.Write("Ingrese el monto: ");
                    monto = Convert.ToInt32(Console.ReadLine());
                    cuenta.cantidad = cuenta.Ingresar(monto);
                    Console.WriteLine($"Monto total: { cuenta.GetCantidad()}");
                    Console.WriteLine();
                    break;
                case 2:
                    //retiro de dinero de la cuenta
                    Console.Write("Ingrese el monto a retirar: ");
                    monto = Convert.ToInt32(Console.ReadLine());
                    cuenta.cantidad = cuenta.Ingresar(monto);
                    Console.WriteLine($"Titular: {cuenta.GetTitular()}");
                    Console.WriteLine($"Monto total: {cuenta.GetCantidad()}");
                    Console.WriteLine();
                    break;
                case 3:
                    //salir del menu
                    bandera = false;
                    break;
            }
        }
    }
}