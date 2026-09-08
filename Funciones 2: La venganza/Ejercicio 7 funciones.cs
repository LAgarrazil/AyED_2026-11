using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            FactoresPrimos(numero);
        }

        static void FactoresPrimos(int numero)
        {
            int divisor = 2;
            int cantidad = 0;

            Console.WriteLine("Descomposición en factores primos:");

            while (numero > 1)
            {
                if (numero % divisor == 0)
                {
                    Console.WriteLine("Factor primo: " + divisor);

                    numero = numero / divisor;
                    cantidad++;
                }
                else
                {
                    divisor++;
                }
            }

            Console.WriteLine("Cantidad total de factores primos: " + cantidad);
        }
    }
}
