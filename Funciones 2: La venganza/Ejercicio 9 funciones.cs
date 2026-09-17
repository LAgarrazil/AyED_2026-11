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

            MayorRepetido(numeros);
        }

        static void MayorRepetido(int[] numeros)
        {
            int mayorCantidad = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                int cantidad = 0;

                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        cantidad++;
                    }
                }

                if (cantidad > mayorCantidad)
                {
                    mayorCantidad = cantidad;
                }
            }

            Console.WriteLine("Los números que más se repitieron son:");

            for (int i = 0; i < numeros.Length; i++)
            {
                int cantidad = 0;
                bool repetido = false;

                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        cantidad++;
                    }
                }

                for (int j = 0; j < i; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        repetido = true;
                    }
                }

                if (cantidad == mayorCantidad && repetido == false)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

            Console.WriteLine("Cantidad de veces que se repitieron: " + mayorCantidad);
        }
    }
}
