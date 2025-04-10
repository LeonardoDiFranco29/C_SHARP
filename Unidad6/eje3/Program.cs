using System;

namespace eje3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=1,con;

             
            while (n >= 0)
            {
                con = 0;
                Console.WriteLine("ingrese un numero");
                n = int.Parse(Console.ReadLine());
                while (n > 0)
                {
                    con++;


                    Console.WriteLine("ingrese otro numero");
                n = int.Parse(Console.ReadLine());

                }
                
                Console.WriteLine("La cantidad de numeros es: "+con);
                
            }
        }
    }
}
