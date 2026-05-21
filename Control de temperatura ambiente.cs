using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("temperatura actual: ");
            int grados = int.Parse(Console.ReadLine());
            int resta = 0;
            while (grados > 24) 
            {
                
                if (grados > 24 )
                {
                    Console.WriteLine("grados: " + (grados - 2));
                    resta -= grados;
                    Console.WriteLine(resta);
                }
                
            }
        }
    }
}
