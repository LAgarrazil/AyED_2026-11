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
            int midclorianos;
            Console.Write("peso en la nave(kg): ");
            midclorianos = Convert.ToInt32(Console.ReadLine());
            if (midclorianos >= 5000 & midclorianos <= 15000)

            {
                Console.WriteLine("Aceptable para entrenamiento Padawan");
            }
            else
            {
                Console.WriteLine("No posee sensibilidad a la Fuerza");
            }



        }
    }
}
