using System;

namespace eje1
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

            int pos = 1;
            int max = numeros[0];
            for (int x = 0; x < 10; x++)
            {
                if (numeros[x] >= max){
                    max = numeros[x];
                    pos = x+1;
                }
            }
            Console.WriteLine("El valor maximo es: "+max+" y su posicion es: "+pos);
            

        }
    }
}
