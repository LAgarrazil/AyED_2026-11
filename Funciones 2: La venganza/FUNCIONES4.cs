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
            Console.Write("Ingrese un número mayor o igual a 0: ");
            int numero = int.Parse(Console.ReadLine());

            int resultado = Factorial(numero);

            Console.WriteLine("El factorial es: " + resultado);
        }

        static int Factorial(int numero)
        {
            int factorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
