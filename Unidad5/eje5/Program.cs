using System;

namespace eje5
{
    class Program
    {
        static void Main(string[] args)
        {
         //   int mayorActualPar = 0, n, menorActualImpar = 0;
//
         //  for (int i = 0; i < 20; i++)
         //  {
         //       Console.WriteLine("ingrese un nro");
         //       n = int.Parse(Console.ReadLine());
         //       
         //       if (i == 0){
         //           mayorActualPar = n;
         //           menorActualImpar = n;   
         // //      }else{
         //           if (n > mayorActualPar && n % 2 == 0){
        //           mayorActualPar = n;
         //           }else if(n < menorActualImpar && n % 2 == 1){
         //               menorActualImpar = n;//
         //           }
         //       }
    //    }
    //  Console.WriteLine(" el máximo de los números pares es: "+mayorActualPar+" y el mínimo de los números impares es: "+menorActualImpar);


                int n, max = 0 , min = 0;

                bool banPar = false, banImpar = false;

                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("ingrese nro" );
                    n = int.Parse( Console.ReadLine() );

                    if (n % 2 == 0){
                        if (banPar == false){
                            banPar = true;
                            max = n;
                        } else if (n > max){
                            max = n;    
                        }
                    } else {
                        if (banImpar == false){
                            banImpar = true;
                            min = n;
                        } else if (n < min){
                            min = n;    
                        }
                    }
                }

                Console.WriteLine(" el máximo de los números pares es: "+max+" y el mínimo de los números impares es: "+min);








      }
    }
}
