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
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese un número: ");
                numeros[i] = int.Parse(Console.ReadLine());
                total += numeros[i];
            }
            double promedio = total / numeros.Length;
            MayorMenor(numeros);
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
            Console.WriteLine("promedio de numeros: " + promedio);
        }
    }
}