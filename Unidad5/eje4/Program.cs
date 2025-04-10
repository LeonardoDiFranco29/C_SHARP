using System;

namespace eje4
{
    class Program
    {
        static void Main(string[] args)
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
                Console.WriteLine("es primo");
            }else{
                Console.WriteLine("no es primo");
            }
            
        }
    }
}
