using System;

namespace eje2
{
    class Program
    {
        static void Main(string[] args)
        {
            float importeTotal,ImporteConDescuento,cantidadDeLitros,descuento;

            Console.WriteLine("Ingrese Importe total: ");
            importeTotal = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros vendida: ");
            cantidadDeLitros =  float.Parse(Console.ReadLine());

            if(cantidadDeLitros > 500){
                descuento = 0.75F;
            }else if(cantidadDeLitros > 301 && cantidadDeLitros < 500){
                descuento = 0.85F;
            }else if(cantidadDeLitros > 101 && cantidadDeLitros < 300){
                descuento = 0.90F;
            } else{
                descuento = 1;
            }
            
            ImporteConDescuento = importeTotal * descuento;
            Console.Write("El importe con descuento es: "+ImporteConDescuento);
        }
    }
}
