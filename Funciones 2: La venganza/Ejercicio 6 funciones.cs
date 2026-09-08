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

            SegundoMayor(numeros);
        }

        static void SegundoMayor(int[] numeros)
        {
            int mayor = numeros[0];
            int segundo = numeros[0];
            bool encontrado = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < mayor)
                {
                    if (encontrado == false || numeros[i] > segundo)
                    {
                        segundo = numeros[i];
                        encontrado = true;
                    }
                }
            }

            if (encontrado == true)
            {
                Console.WriteLine("El segundo mayor es: " + segundo);
            }
            else
            {
                Console.WriteLine("No existe un segundo número diferente al mayor.");
            }
        }
    }
}