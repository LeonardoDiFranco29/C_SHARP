using System;

namespace eje2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contadorNumeros, conImpares, grupoDeImparesMaximo = 0, min, contadorOrdenados=0;
            double procentajeImpares, porcentajeMaximo=-1, porcentajeMaximoImpares=-1;
            bool banOrdenados;
            for (int i = 0; i < 5; i++)
            {
                
                contadorNumeros = 0;
                conImpares= 0;
                banOrdenados = true;
                Console.WriteLine("ingresa un numero");
                n= int.Parse(Console.ReadLine());
                
                min=n;
                while (n != 0){
                     contadorNumeros++;
                    if(n % 2 != 0){
                        conImpares++;
                    }

                    if(n <= min){
                        min = n;
                    } else {
                        banOrdenados = false;
                    }

                    Console.WriteLine("ingresa otro numero");
                    n= int.Parse(Console.ReadLine());
                }

                    procentajeImpares= conImpares*100/contadorNumeros;
                    if(procentajeImpares > porcentajeMaximo){
                    porcentajeMaximo = procentajeImpares;
                    grupoDeImparesMaximo = i + 1;
                    porcentajeMaximoImpares = procentajeImpares;
                    }
                if(banOrdenados){
                    contadorOrdenados++;
                }
            }
            Console.WriteLine("El grupo con mayor porcentaje de impares es el: " + grupoDeImparesMaximo+" con un porcentaje de: "+porcentajeMaximoImpares+"%");
            Console.WriteLine("La cantidad de grupos ordenados de mayor a menor son: " + contadorOrdenados);
        }
    }
}
