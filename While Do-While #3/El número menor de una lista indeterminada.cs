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
            int numero;
            int minimo = 0;
            bool primerNumero = true;

            do
            {
                Console.Write("Ingrese un número (negativo para finalizar): ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    if (primerNumero)
                    {
                        minimo = numero;
                        primerNumero = false;
                    }
                    else if (numero < minimo)
                    {
                        minimo = numero;
                    }
                }

            } while (numero >= 0);

            if (!primerNumero)
            {
                Console.WriteLine("número menor: " + minimo);
            }
            else
            {
                Console.WriteLine("No se ingresaron números positivos.");
            }
        }
    }
}
