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
            int numero1;
			int numero2;
			int numero3;
			int numeromayor;
            Console.Write("numero 1: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("numero 2: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("numero 3: ");
            numero3 = Convert.ToInt32(Console.ReadLine());
            if (numero1 > numero2 & numero1 > numero3)
            {
                numeromayor = numero1;
                Console.WriteLine("numero mayor: " + numeromayor);
            }

            else if (numero2 > numero1 & numero2> numero3)
			{
				numeromayor = numero2;
                Console.WriteLine("numero mayor: " + numeromayor);
			}
			
			else
				numeromayor = numero3;
				Console.WriteLine("numero mayor: " + numeromayor);
				
				
        }
    }
}
