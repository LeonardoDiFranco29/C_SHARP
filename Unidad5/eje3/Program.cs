using System;

namespace eje3
{
    class Program
    {
        static void Main(string[] args)
        {
            float promedio = 0, edad, sumaDeEdades = 0, mayores= 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("ingrese edad");
                edad= float.Parse(Console.ReadLine());
                if (edad>18){
                    sumaDeEdades += edad;
                    mayores++;
                }
            }
            promedio = sumaDeEdades / mayores;

            Console.WriteLine("El promedio es de: "+promedio);
        }
    }
}
