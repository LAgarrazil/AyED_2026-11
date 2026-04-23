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
            int promedio;
			int distancia;
            Console.Write("promedio: ");
            promedio = Convert.ToInt32(Console.ReadLine());
			Console.Write("distancia(km): ");
            distancia = Convert.ToInt32(Console.ReadLine());
            if (promedio >= 8 || distancia >= 50)
            {
                
                Console.WriteLine("beca concedida");
            }

            else
                Console.WriteLine("beca denegada");
        }
    }
}
