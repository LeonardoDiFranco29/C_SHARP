using System;

namespace eje3
{
    class Program
    {
        static void Main(string[] args)
        {
            char letraActual;
            char letraNueva;
            char[] frase = new char[30];
            char letra;
            int indice = 0;

            Console.WriteLine("ingrese una letra");
            letra = char.Parse(Console.ReadLine());
            while(letra != '0' && indice < 30){
                frase[indice] = letra;
                Console.WriteLine("ingrese otra letra");
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            frase[indice]= '\0';
            Console.WriteLine("la frase completa es: ");
            indice = 0;
            while(frase[indice] != '\0'){
                Console.Write(frase[indice]);
                indice++;
            }
            Console.WriteLine(" ingrese letra a reemplazar:");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la letra nueva:");
            letraNueva = char.Parse(Console.ReadLine());

            indice = 0;
            while(frase[indice] != '\0'){
                if(frase[indice] == letraActual){
                    frase[indice] = letraNueva;
                }
                indice++;
            }
            Console.WriteLine("la frase nueva es: ");
            indice = 0;
            while(frase[indice] != '\0'){
                Console.Write(frase[indice]);
                indice++;
            }
        }
    }
}
