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
            int saldo = 10000;
            int opcion;

            do
            {
                Console.WriteLine("1. Depositar dinero");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Ver saldo actual");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese una opcion: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Monto a depositar: ");
                        int deposito = Convert.ToInt32(Console.ReadLine());
                        saldo += deposito;
                        Console.WriteLine("Depósito realizado.");
                        break;

                    case 2:
                        Console.Write("Monto a retirar: ");
                        int retiro = Convert.ToInt32(Console.ReadLine());

                        if (retiro <= saldo)
                        {
                            saldo -= retiro;
                            Console.WriteLine("Retiro realizado.");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Saldo actual: $" + saldo);
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 4);

            Console.WriteLine("Programa finalizado.");
        }
    }
}
