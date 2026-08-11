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
            double[] temperatura = new double[7];
            double total = 0;
            int dia = 0;
            for (int i = 0; i < temperatura.Length; i++)
            {
                dia++;
                Console.WriteLine("temperatura dia: " + dia);
                temperatura[i] = Convert.ToDouble(Console.ReadLine());
                total += temperatura[i];
            }
            double mayor = temperatura[0];
            double menor = temperatura[0];
            for (int i = 0; i < temperatura.Length; i++)
            {
               
                if (temperatura[i] > mayor)
                {
                    
                    mayor = temperatura[i];
                }
                else if (temperatura[i] < menor)
                {
                    menor = temperatura[i];
                }
            }
            double promedio = total / temperatura.Length;
            Console.WriteLine("temeratura mayor: " + mayor);
            Console.WriteLine("temeratura menor: " + menor);
            Console.WriteLine("temeratura promedio: " + promedio);
        }
    }
}
