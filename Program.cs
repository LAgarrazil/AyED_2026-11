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
            Console.WriteLine("(1)depositar dinero");
            Console.WriteLine("(2)retirar dinero");
            Console.WriteLine("(3)ver saldo actual");
            Console.WriteLine("(4)salir");
            Console.WriteLine("ingrese una opcion: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            int dinero = 10000;
            while (opcion > 4)
            {
                if (opcion == 1)
                {
                    Console.WriteLine("cantidad de dinero: ");
                    int movimiento = Convert.ToInt32(Console.ReadLine());
                    dinero += movimiento;
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("cantidad de dinero: ");
                    int movimiento = Convert.ToInt32(Console.ReadLine());
                    dinero -= movimiento;
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("saldo actual: " + dinero);
                }
                else if (opcion > 4)
                {
                    Console.WriteLine("opcion invalida");
                }
                else if (opcion == 4)
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("(1)depositar dinero");
                Console.WriteLine("(2)retirar dinero");
                Console.WriteLine("(3)ver saldo actual");
                Console.WriteLine("(4)salir");
                Console.WriteLine("ingrese una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Programa finalizado");
        }
    }
}
