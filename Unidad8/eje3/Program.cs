using System;

namespace eje3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, conPrimos=0, acuPrimos=0, promedio=0;

            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            while (n != 0){
                
                if (primo(n)){
                    conPrimos++ ;
                    acuPrimos += n ;
                    Console.WriteLine(n+" es primo");
                }
                
                
                Console.WriteLine("Ingrese otro");
                n = int.Parse(Console.ReadLine());
            }
            promedio= acuPrimos/conPrimos ;
            Console.WriteLine("El promedio de los numeros primos es de: "+promedio+" y la cantidad de numeros primos son: "+conPrimos);
        }
        static bool primo(int n){
            int con=0;
            for (int x = 1; x <= n; x++)
            {
                if(n % x == 0){
                    con++;
                }
            }
            if (con == 2){
                return true;
            } else {
                return false;
            }
        }
    }
}
