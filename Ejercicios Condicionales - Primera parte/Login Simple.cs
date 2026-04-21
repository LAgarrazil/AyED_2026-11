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
            int grados;
            Console.Write("grados: ");
            grados = Convert.ToInt32(Console.ReadLine());
            if (grados < 0)
            {
                Console.WriteLine("Peligro de congelamiento");
            }

            else if (grados >= 0 & grados <= 15)
            {
                Console.WriteLine("Mucho frío");
            }
            else
            {
                Console.WriteLine("Clima agradable");
            }
        }
    }
}