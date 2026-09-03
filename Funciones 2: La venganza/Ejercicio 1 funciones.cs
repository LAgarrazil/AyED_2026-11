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
            double total = 0;
            int numero = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                numero++;

                Console.Write("Ingrese el " + numero + "° número: ");
                numeros[i] = int.Parse(Console.ReadLine());

                total += numeros[i];
            }

            double promedio = total / numeros.Length;

            MayorMenor(numeros);
            parimpar(numeros);

            Console.WriteLine("Promedio de números: " + promedio);
        }

        static void MayorMenor(int[] numeros)
        {
            int mayor = numeros[0];
            int menor = numeros[0];

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            Console.WriteLine("El mayor es: " + mayor);
            Console.WriteLine("El menor es: " + menor);
        }

        static void parimpar(int[] numeros)
        {
            int pares = 0;
            int impares = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine("Cantidad de pares: " + pares);
            Console.WriteLine("Cantidad de impares: " + impares);
        }
    }
}