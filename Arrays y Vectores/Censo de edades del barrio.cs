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
            double[] edad = new double[10];
            int vecino = 0;
            int menores = 0;
            int mayores = 0;
            int promedio = 0;
            for (int i = 0; i < edad.Length; i++)
            {
                vecino++;
                Console.WriteLine("edad de vecino n°: " + vecino);
                edad[i] = Convert.ToDouble(Console.ReadLine());
                if (edad[i] <= 17)
                {
                    menores++;
                }
                else if (edad[i] >= 65)
                {
                    mayores++;
                }
                else
                {
                    promedio++;
                }
            }
            Console.WriteLine("vecinos menores: " + menores);
            Console.WriteLine("vecinos mayores: " + mayores);
            Console.WriteLine("vecinos de edad promedio: " + promedio);
        }
    }
}