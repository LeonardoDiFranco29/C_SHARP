using System;

namespace eje5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;

            Console.WriteLine("ingrese el primer numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el cuarto numero: ");
            n4 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n2 > n3 && n3 > n4){
                Console.WriteLine("Estan ordenados de forma decreciente los siguientes numeros: "+n1+" "+n2+" "+n3+" "+n4);
            } else{
                Console.WriteLine("NO Estan ordenados de forma decreciente los siguientes numeros: "+n1+" "+n2+" "+n3+" "+n4);
            }
        }
    }
}
