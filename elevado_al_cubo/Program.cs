﻿using System;

namespace elevado_al_cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, resultado;

            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            resultado = n1 * n1 * n1;

            Console.WriteLine("El resultado es: "+ resultado);
        }
    }
}
