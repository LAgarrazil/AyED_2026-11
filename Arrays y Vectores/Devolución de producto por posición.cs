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
            double[] precio = new double[10];
            int devolucion = 0;
            int producto = 0;
            double total = 0;
            for (int i = 0; i < precio.Length; i++)
            {
                producto++;
                Console.WriteLine("precio producto n°: " + producto);
                precio[i] = Convert.ToDouble(Console.ReadLine());
                total += precio[i];
            }
            Console.WriteLine("total: " + total);
            Console.WriteLine("devolucion de producto n°: ");
            devolucion = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < precio.Length; i++)
            {
                if (precio[i] == devolucion)
                {
                    Console.WriteLine("devolucion: " + precio[i]);
                    total = total - precio[i];
                }
            }
            Console.WriteLine("total: " + total);
        }
    }
}
