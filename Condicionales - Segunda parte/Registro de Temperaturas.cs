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
            int gastos = 0;
            int contador = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("gasto " + i);
                gastos = Convert.ToInt32(Console.ReadLine());
                if(gastos > 500)
                {
                    contador++;
                }
            }
            Console.WriteLine("gastos elevados: " + contador);



        }
    }
}
