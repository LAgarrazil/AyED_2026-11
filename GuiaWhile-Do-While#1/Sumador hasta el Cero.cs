using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el dinero: ");
            int numero = int.Parse(Console.ReadLine());
            int total = 0;
            do
            {
                if (numero > 0)
                {
                    Console.WriteLine("ingrese el dinero: ");
                    numero = int.Parse(Console.ReadLine());
                    total += numero;
                }
            } while (numero > 0 );;
            Console.WriteLine("total: " + total);


        }
    }
}
