using System;

namespace eje1
{
    class Program
    {
        static void Main(string[] args)
        {
            int precioArticulo= 0, cantidadVendida=0;

            Console.WriteLine("Ingrese El precio del Articulo: ");
            precioArticulo= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantida vendida: ");
            cantidadVendida= int.Parse(Console.ReadLine());

            Console.WriteLine("El monto total es de: "+producto(ref precioArticulo,ref cantidadVendida));


        }

        static int producto(ref int n1, ref int n2){
            int r;
            r= n1 * n2;
            return r;

        }
    }
}
