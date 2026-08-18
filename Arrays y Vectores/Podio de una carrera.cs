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
            int corredor = 0;
            int mejortiempo = 0;
            int peortiempo = 0;
            double[] tiempo = new double[6];

            for (int i = 0; i < corredores.Length; i++)
            {
                corredor++;
                Console.WriteLine("tiempo corredor n°: " + corredor);
                tiempo[i] = Convert.ToDouble(Console.ReadLine());
            }

            double mayor = tiempo[0];
            double menor = tiempo[0];

            mejortiempo = 1;
            peortiempo = 1;

            for (int i = 0; i < corredores.Length; i++)
            {
                if (tiempo[i] > mayor)
                {
                    mayor = tiempo[i];
                    peortiempo = i + 1;
                }
                else if (tiempo[i] < menor)
                {
                    menor = tiempo[i];
                    mejortiempo = i + 1;
                }
            }

            Console.WriteLine("mejor tiempo: " + menor + " corredor n°" + mejortiempo);
            Console.WriteLine("peor tiempo: " + mayor + " corredor n°" + peortiempo);
        }
    }
}