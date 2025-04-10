using System;

namespace eje4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] articulos = new int[15];
            int cantidadVendida;
            int nroArticulo;
            
            for (int x = 0; x < 15; x++)
            {
                articulos[x] = 0;

            }
            
            
            
            Console.WriteLine("ingrese el nro de articulo: ");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad Vendida: ");
            cantidadVendida = int.Parse(Console.ReadLine());
            
            while(nroArticulo != 0){

                articulos[nroArticulo - 1] += cantidadVendida;
                Console.WriteLine("ingrese el nro de articulo: ");
                nroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la cantidad Vendida: ");
                cantidadVendida = int.Parse(Console.ReadLine());
            }
            
            int max = articulos[0];
            int nroMaximo = 1;

            for (int x = 0; x < 15; x++)
            {
                if (articulos[x] >= max){
                    max = articulos[x];
                    nroMaximo= x + 1;
                }
            }
            Console.WriteLine("el producto mas vendido es: "+nroMaximo+" con "+articulos[nroMaximo-1]+" ventas");
            
            for (int x = 0; x < 15; x++)
            {
                if(articulos[x] == 0){
                    Console.WriteLine("el producto "+(x+1)+" no tuvo ventas");
                }
            }

            Console.WriteLine("La cantidad vendida del articulo 10 es de: "+articulos[9]);

        }
    }
}
