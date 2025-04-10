using System;

namespace kilometros
{
    class Program
    {
        static void Main(string[] args)
        {
            float kilometro, velocidadPorHora, tiempo;

            Console.WriteLine("Ingrese Kilometros: ");
            kilometro = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese velocidad: ");
            velocidadPorHora = float.Parse(Console.ReadLine());
            
            
            tiempo = kilometro / velocidadPorHora;

            Console.WriteLine("El tiempo es: "+tiempo.ToString("0.00"));
        }
    }
}
