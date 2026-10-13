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
            Console.Write("Ingrese un numero entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            int cantidad = 0;

            for (int i = 1; i < numero; i++)
            {
                int suma = 0;
                string representacion = "";

                for (int x = i; suma < numero; x++)
                {
                    suma = suma + x;

                    if (representacion == "")
                    {
                        representacion = x.ToString();
                    }
                    else
                    {
                        representacion = representacion + " + " + x;
                    }

                    if (suma == numero && x > i)
                    {
                        Console.WriteLine(numero + " = " + representacion);
                        cantidad++;
                    }
                }
            }

            if (cantidad == 0)
            {
                Console.WriteLine("No se encontraron representaciones.");
            }
        }
    }
}
