using System;

namespace promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, promedio;

            Console.WriteLine("ingrese nota: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otra nota: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otra nota: ");
            n3 = float.Parse(Console.ReadLine());

            promedio= (n1 + n2 + n3) / 3;

            Console.WriteLine("El promedio es de: " + promedio.ToString("0.00"));
        }
    }
}
