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
            double[] precio = new double[8];
            double presupuesto = 0;
            int producto = 0;
            int accesible = 0;
            int inaccesible = 0;
            for (int i = 0; i < precio.Length; i++)
            {
                producto++;
                Console.WriteLine("precio producto n°: " + producto);
                precio[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("presupuesto: ");
            presupuesto = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < precio.Length; i++)
            {
                if (precio[i] <= presupuesto)
                {
                    accesible++;
                }
                else if (precio[i] >= presupuesto)
                {
                    inaccesible++;
                }
            }
            Console.WriteLine("productos accesibles: " + accesible);
            Console.WriteLine("productos inaccesibles: " + inaccesible);
        }
    }
}