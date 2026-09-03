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
            Console.Write("Ingrese un número positivo: ");
            int numero = int.Parse(Console.ReadLine());

            bool resultado = Perfecto(numero);

            if (resultado == true)
            {
                Console.WriteLine("El número es perfecto.");
            }
            else
            {
                Console.WriteLine("El número no es perfecto.");
            }
        }

        static bool Perfecto(int numero)
        {
            int suma = 0;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma += i;
                }
            }

            if (suma == numero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}