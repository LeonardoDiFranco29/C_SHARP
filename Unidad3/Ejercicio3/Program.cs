using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float importeVenta, importeFinal, descuento;
            
            Console.WriteLine("ingrese importe:");
            importeVenta = float.Parse(Console.ReadLine());

            if (importeVenta >= 5000){
                descuento = 0.82F;
            }else if(importeVenta < 1000 ){
                descuento = 1;
            }else{
                descuento = 0.90F;
            }
            
            importeFinal = importeVenta * descuento;

            Console.WriteLine("El importe Final es: " + importeFinal);

        }
    }
}
