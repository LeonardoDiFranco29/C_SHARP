using System;

namespace eje2
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadorDePares = 0, n=0;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                contadorDePares += par(n);
            }
            Console.WriteLine("La cantidad de numeros pares son: "+contadorDePares);
        }

        static int par(int n){
            if(n % 2 == 0){
                return 1;
            } else {
                return 0;
            }
        }
    }
}
