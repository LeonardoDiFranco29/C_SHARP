﻿using System;

namespace eje4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("ingrese el primer numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero: ");
            n3 = int.Parse(Console.ReadLine());

            if ((n1 + n2) > (n2 * n3)){
                Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero");
            }else{
                Console.WriteLine("La suma de los dos primeros NO es mayor al producto del segundo con el tercero");
            }
        }
    }
}
