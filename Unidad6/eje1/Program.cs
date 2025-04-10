using System;

namespace eje1
{
    class Program
    {
        static void Main(string[] args)
        {   
            int contadorDePrimos= 0;
            for (int x = 0; x < 10; x++)
            {
                int n, con=0;
            
                Console.WriteLine("ingrese un nro");
                n= int.Parse(Console.ReadLine());
            
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0){
                    con++; 
                    }
                
                }

                if (con == 2){
                contadorDePrimos++;
                }
            }
            Console.WriteLine("La cantidad De Primos Son: "+contadorDePrimos);
        }
    }
}
