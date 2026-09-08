using System;

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

            Primos(numeros);
        }

        static void Primos(int[] numeros)
        {
            int mayor = 0;
            int menor = 0;
            int cantidad = 0;

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
                int divisores = 0;

                for (int x = 1; x <= i; x++)
                {
                    if (i % x == 0)
                    {
                        divisores++;
                    }
                }

                if (divisores == 2)
                {
                    Console.WriteLine("Número primo: " + i);
                    cantidad++;
                }
            }

            Console.WriteLine("Cantidad de números primos: " + cantidad);
        }
    }
}