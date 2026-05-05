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
            int resto = 0;
            int contador = 0;
            Console.WriteLine("numero entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 2; i <= numero; i++)
            {
                resto = numero % i;
                if (resto == 0)
                {
                    contador ++;
                }

            }
            if (contador == 1)
            {
                Console.WriteLine(numero + " es primo");
            }
            else
            {
                Console.WriteLine(numero + " no es primo");
            }
            



        }
    }
}
