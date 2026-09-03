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
            int[] numeros = new int[2];
            int numero = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                numero++;

                Console.Write("Ingrese el " + numero + "° número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Comprendidos(numeros);
            ParImpar(numeros);
        }

        static void Comprendidos(int[] numeros)
        {
            int mayor = 0;
            int menor = 0;

            if (numeros[0] > numeros[1])
            {
                mayor = numeros[0];
                menor = numeros[1];
            }
            else
            {
                mayor = numeros[1];
                menor = numeros[0];
            }

            for (int i = menor + 1; i < mayor; i++)
            {
                Console.WriteLine("Numeros comprendidos: " + i);
            }
        }

        static void ParImpar(int[] numeros)
        {
            int mayor = 0;
            int menor = 0;
            int pares = 0;
            int impares = 0;
            int suma = 0;
            if (numeros[0] > numeros[1])
            {
                mayor = numeros[0];
                menor = numeros[1];
            }
            else
            {
                mayor = numeros[1];
                menor = numeros[0];
            }

            for (int i = menor + 1; i < mayor; i++)
            {
                if (i % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
                suma += i;
            }
            Console.WriteLine("suma de numeros comprendidos: " + suma);
            Console.WriteLine("Cantidad de pares: " + pares);
            Console.WriteLine("Cantidad de impares: " + impares);
        }


    }
}