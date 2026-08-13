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
            int[] corredores = new int[6];
            int tienda1 = 0;
            int tienda2 = 0;
            int total1 = 0;
            int total2 = 0;
            int corredor = 0;
            int diax = 0;
            for (int i = 0; i < corredores.Length; i++)
            {
                corredor++;
                Console.WriteLine("tiempo(s)corredor n°: " + corredor);
                corredores[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < corredores.Length; i++)
            {
                diax++;
                if (tienda1 > tienda2)
                {
                    Console.WriteLine("recaudacion mayor dia: "+ diax + " tienda 1");
                }
                else
                {
                    Console.WriteLine("recaudacion mayor dia: " + diax + " tienda 2");
                }
            }
            Console.WriteLine("recaudacion tienda 1: " + total1);
            Console.WriteLine("recaudacion tienda 2: " + total2);
            if (total1 > total2)
            {
                Console.WriteLine("recaudacion mayor: tienda 1");
            }
            else
            {
                Console.WriteLine("recaudacion mayor: tienda 2");
            }
        }
    }
}
