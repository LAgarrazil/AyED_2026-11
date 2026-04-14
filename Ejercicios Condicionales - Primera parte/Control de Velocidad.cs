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
            int velocidad;
            Console.Write("velocidad: ");
            velocidad = Convert.ToInt32(Console.ReadLine());
            if (velocidad < 120)
            {
                Console.WriteLine("Multa en camino: Exceso de velocidad");
            }
            else
            {
                Console.WriteLine("Conducción segura".);
            }
        }
    }
}
