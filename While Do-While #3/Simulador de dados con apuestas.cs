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
            int creditos = 100;
            int apuesta;

            do
            {
                Console.WriteLine("Créditos : " + creditos);
                Console.Write("apuesta (0 para retirarse): ");
                apuesta = int.Parse(Console.ReadLine());

                if (apuesta > 0 && apuesta <= creditos)
                {
                    Console.Write("dado 1 (1-6): ");
                    int dado1 = int.Parse(Console.ReadLine());

                    Console.Write("dado 2 (1-6): ");
                    int dado2 = int.Parse(Console.ReadLine());

                    int suma = dado1 + dado2;

                    if (suma == 7 || suma == 11)
                    {
                        creditos += apuesta;
                        Console.WriteLine("Ganaste");
                    }
                    else
                    {
                        creditos -= apuesta;
                        Console.WriteLine("Perdiste.");
                    }
                }
                else if (apuesta != 0)
                {
                    Console.WriteLine("Apuesta inválida.");
                }

            } while (creditos > 0 && apuesta != 0);

            Console.WriteLine("Saldo final: " + creditos + " créditos");
        }
    }
}
