using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroSecreto = 67;
            int cantidadIntentos = 0;
            bool adivino = false;

            while (cantidadIntentos < 5 && !adivino)
            {
                Console.Write("Adivina el numero: ");
                int intento = Convert.ToInt32(Console.ReadLine());

                cantidadIntentos++;

                if (intento == numeroSecreto)
                {
                    adivino = true;
                }
                else if (intento < numeroSecreto)
                {
                    Console.WriteLine("El numero es mayor.");
                }
                else
                {
                    Console.WriteLine("El numero es menor.");
                }
            }

            if (adivino)
            {
                Console.WriteLine("Ganaste");
                Console.WriteLine("Intentos usados: " + cantidadIntentos);
            }
            else
            {
                Console.WriteLine("Perdiste.");
                Console.WriteLine("El número secreto era: " + numeroSecreto);
                Console.WriteLine("Intentos usados: " + cantidadIntentos);
            }
        }
    }
}
