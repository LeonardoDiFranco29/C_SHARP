using System;

namespace eje2
{
    class Program
    {
        static void Main(string[] args)
        {
           int mayorActual = 0, n;

           for (int i = 0; i < 10; i++)
           {
                Console.WriteLine("ingrese un nro");
                n = int.Parse(Console.ReadLine());
                
                if (i == 0){
                    mayorActual = n;
                }else{
                    if (n > mayorActual){
                    mayorActual = n;
                }
                }
                
                

           }
           
           Console.WriteLine("el mayor es: "+mayorActual);
        }
    }
}
