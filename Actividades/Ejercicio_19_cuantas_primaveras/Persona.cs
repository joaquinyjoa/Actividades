using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19_cuantas_primaveras
{
    public class Persona
    {
        private string nombre;
        private new DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string SetNombre(string nombre) 
        {
            this.nombre = nombre;
            return this.nombre;
        }

        public string GetNombre() 
        {
            return nombre;
        }

        public DateTime SetFechaDeNacimiento(DateTime fechaDeNacimiento) 
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
            return this.fechaDeNacimiento;
        }

        public DateTime GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        public int SetDni(int dni)
        {
            this.dni = dni;
            return dni;
        }

        public int GetDni() 
        {
            return dni;
        }

        private int CalcularEdad(DateTime fechaDeNacimiento) 
        {
            int edad;
            DateTime fechaActual = DateTime.Now;

            edad = fechaActual.Year - fechaDeNacimiento.Year;

            return edad;
        }

        public string Mostrar() 
        {
            StringBuilder mensaje = new StringBuilder();
            int edad = CalcularEdad(GetFechaDeNacimiento());
            mensaje.AppendLine($"Nombre : {GetNombre()}");
            mensaje.AppendLine($"fecha de nacimiento : {GetFechaDeNacimiento().ToString("dd/MM/yyyy")}");
            mensaje.AppendLine($"DNI : {GetDni()}");
            mensaje.AppendLine($"edad : {edad}");
            return mensaje.ToString();
        }

        public bool EsMayorEdad() 
        {
            int edad = CalcularEdad(GetFechaDeNacimiento());
            bool bandera = false;
            if (edad >= 18)
            {
                bandera = true;
            }
            return bandera;
        }

    }
}
