using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números: ");
            int cantidad = int.Parse(Console.ReadLine());
            int[] numeros = new int[cantidad];
            int numero = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                numero++;
                Console.Write("Ingrese el " + numero + "° número: ");
                numeros[i] = int.Parse(Console.ReadLine());

            }
            positivosnegativos(numeros);
            promedio(numeros);
        }
        static void positivosnegativos(int[] numeros)
        {
            int positivo = 0;
            int negativo = 0;
            int cero = 0;
            for (int i = 0; i < numeros.Length; i++)
            {

                if (numeros[i] >= 1)
                {
                    positivo++;
                }

                else if (numeros[i] <= -1)
                {
                    negativo++;
                }
                else
                {
                    cero++;
                }
            }

            Console.WriteLine("numeros positivos: " + positivo);
            Console.WriteLine("numeros negativos: " + negativo);
            Console.WriteLine("numeros iguales a 0: " + cero);
        }

        static void promedio(int[] numeros)
        {
            int totalpositivos = 0;
            int totalnegativos = 0;
            double promediopositivos = 0;
            double promedionegativos = 0;
            double positivos = 0;
            double negativos = 0;
            for (int i = 0; i < numeros.Length; i++)
            {

                if (numeros[i] >= 1)
                {
                    positivos++;
                    totalpositivos += numeros[i];
                    promediopositivos = totalpositivos / positivos;
                }
                else if (numeros[i] <= -1)
                {
                    negativos++;
                    totalnegativos += numeros[i];
                    promedionegativos = totalpositivos / negativos;
                }
            }
            Console.WriteLine("promedio numeros positivos: " + promediopositivos);
            Console.WriteLine("promedio numeros negativos: " + promedionegativos);
        }

    }
}
