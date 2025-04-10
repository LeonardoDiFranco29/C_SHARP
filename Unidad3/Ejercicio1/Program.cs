using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            
            Console.WriteLine("Ingrese un numero: ");
            edad = int.Parse(Console.ReadLine());

            if (edad > 10){
                Console.WriteLine("Es mayor a 10");
            }else{
                Console.WriteLine("No es mayor a 10");
            }
        }
    }
}
