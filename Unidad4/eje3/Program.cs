using System;

namespace eje3
{
    class Program
    {
        static void Main(string[] args)
        {
            int procesador, memoria, disco;
            float precio = 0;

            Console.WriteLine("ingrese procesador: ");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese memoria: ");
            memoria = int.Parse(Console.ReadLine());
            Console.WriteLine("Amplia Disco?: ");
            disco = int.Parse(Console.ReadLine());

            
           

            if (procesador == 1 && memoria == 1){
                precio = 800;
            }else if (procesador == 1 && memoria == 2){
                precio = 900;
            }else if (procesador == 1 && memoria == 3){
                precio = 1000;
            }else if (procesador == 2 && memoria == 1){
                precio = 900;
            }else if (procesador == 2 && memoria == 2){
                precio = 1000;
            }else if (procesador == 2 && memoria == 3){
                precio = 1400;
            }else if (procesador == 3 && memoria == 1){
                precio = 1200;
            }else if (procesador == 3 && memoria == 2){
                precio = 1400;
            }else if (procesador == 3 && memoria == 3){
                precio = 2000;
            }

            if (disco ==1){
                precio = precio + 300;
            }
            Console.WriteLine("El precio total es: " + precio);
        }
    }
}
