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
            double nota;
            Console.Write("tu nota: ");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 7 & nota <= 10)
            {
                Console.WriteLine("promocionado");
            }
            else if (nota >= 4 & nota <= 10)
            {
                Console.WriteLine("a finales");
            }
            else
            {
                Console.WriteLine("recuperatorio");
            }
        }
    }
}
