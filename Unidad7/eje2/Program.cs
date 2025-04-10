using System;

namespace eje2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("ingrese un numero");
                numeros[x] = int.Parse(Console.ReadLine());
            }

            int acu = 0;
            int promedio = 0;
            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
            }
            promedio = acu / 10;
            Console.WriteLine("El promedio es de: "+promedio);
            for (int x = 0; x < 10; x++)
            {
                if (numeros[x] > promedio){
                    Console.WriteLine("El valor "+numeros[x]+" es mayor al promedio");
                }
            }
        }
    }
}
