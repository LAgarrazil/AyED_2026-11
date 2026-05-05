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
            int grados = 0;
            int contador = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("grados dia " + i);
                grados = Convert.ToInt32(Console.ReadLine());
                if(grados < 0)
                {
                    contador++;
                }
            }
            Console.WriteLine("dias de frio extremo: " + contador);



        }
    }
}
