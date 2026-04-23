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
            int saldo;
			int retiro;
            Console.Write("saldo actual: ");
            saldo = Convert.ToInt32(Console.ReadLine());
			Console.Write("retirar: ");
            retiro = Convert.ToInt32(Console.ReadLine());
            if (retiro > saldo)
            {
                
                Console.WriteLine("fondos insuficientes");
            }

            else if (retiro % 1000 == 0)
			{
                Console.WriteLine("entregando billetes");
			}
			
			else
				Console.WriteLine("solo billetes de 1000");
				
				
        }
    }
}
