using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 16;

       //   if(edad > 20){
       //         if(edad > 30){
       //             Console.WriteLine("30 off");
       //         }else{
       //             Console.WriteLine("21 off");
       //         }
       //     } else {
       //         Console.WriteLine("10 off");
       //     }
       //     Console.WriteLine("fin");

            if (edad > 30){
                Console.WriteLine("30 off");
           } else if(edad > 20){
                Console.WriteLine("21 off");
           }else{
                Console.WriteLine("10 off");
           }
            Console.WriteLine("fin");
        }
    }
}
