using System;

namespace Ejercicio_21_invento_argentino
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            // Inicializa la tinta con la cantidad proporcionada, asegurando que no supere el máximo
            SetTinta(tinta);
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            // Ajustar el nivel de tinta asegurando que esté dentro del rango válido
            short nuevaTinta = (short)(this.tinta + tinta);
            if (nuevaTinta > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
            else if (nuevaTinta < 0)
            {
                this.tinta = 0;
            }
            else
            {
                this.tinta = nuevaTinta;
            }
        }

        public void Recarcar()
        {
            
            SetTinta(this.tinta);
        }

        public string Pintar(short gasto)
        {
            // Calcular la tinta gastada
            short tintaUsada = Math.Min(gasto, this.tinta);
            SetTinta((short)-tintaUsada); // Restar la tinta usada

            // Crear el dibujo basado en la tinta gastada
            string dibujo = new string('*', tintaUsada);
            return dibujo;
        }
    }
}
