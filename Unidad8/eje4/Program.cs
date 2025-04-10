using System;

namespace eje4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int estado = 0;
            Console.WriteLine("ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            positivoNegativoCero(n,ref estado);
            Console.WriteLine("El numero: "+n+" es por referencia "+estado);
        }
        static void positivoNegativoCero(int n, ref int estado){
            if(n > 0){
                estado = 1;
            } else if (n < 0){
                estado = -1;
            } else {
                estado = 0;
            }
        }
    }
}
