using System;

namespace sueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float comision, sueldoTotal, totalFacturado;

            float sueldoFijo = 15000;
            float porcentajeComision = 0.05F;

            Console.WriteLine("Ingrese total facturado: ");
            totalFacturado = float.Parse(Console.ReadLine());
            comision = totalFacturado * porcentajeComision;
            sueldoTotal = comision + sueldoFijo;

            Console.WriteLine("El sueldo total es: "+sueldoTotal);
        }
    }
}
