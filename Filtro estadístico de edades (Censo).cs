using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int sumaEdades = 0;
            int cantidadPersonas = 0;
            int mayores = 0;
            int menores = 0;

            do
            {
                Console.Write("Ingrese una edad (-1 para finalizar): ");
                edad = int.Parse(Console.ReadLine());

                if (edad >= 0)
                {
                    sumaEdades += edad;
                    cantidadPersonas++;

                    if (edad >= 18)
                    {
                        mayores++;
                    }
                    else
                    {
                        menores++;
                    }
                }

            } while (edad >= 0);

            double promedio = 0;

            if (cantidadPersonas > 0)
            {
                promedio = (double)sumaEdades / cantidadPersonas;
            }

            Console.WriteLine("Promedio de edad: " + promedio);
            Console.WriteLine("Mayores de edad: " + mayores);
            Console.WriteLine("Menores de edad: " + menores);
        }
    }
}
