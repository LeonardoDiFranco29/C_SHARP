﻿using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4;

            Console.WriteLine("ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("ingrese otro numero: ");
            n2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("ingrese otro numero: ");
            n3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("ingrese otro numero: ");
            n4 = int.Parse(Console.ReadLine());

            if (n1 > 100){
                Console.WriteLine(""+ n1);
            }
            if (n2 > 100){
                Console.WriteLine(""+ n2);
            }
            if (n3 > 100){
                Console.WriteLine(""+ n3);
            }
            if (n4 > 100){
                Console.WriteLine(""+ n4);
            }
        }
    }
}
