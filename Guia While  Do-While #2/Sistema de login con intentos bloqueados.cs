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
            string usuario = "";
            string contraseña = "";
            int intentos = 0;

            do
            {
                Console.Write("Ingrese usuario: ");
                usuario = Console.ReadLine();

                Console.Write("Ingrese contraseña: ");
                contraseña = Console.ReadLine();

                if (usuario != "juanceto01" || contraseña != "soybatman")
                {
                    intentos++;
                    Console.WriteLine("error");
                }

                if (intentos == 3)
                {
                    break;
                }

            } while (usuario != "juanceto01" || contraseña != "soybatman");

            if (usuario == "juanceto01" && contraseña == "soybatman")
            {
                Console.WriteLine("Bienvenido al sistema");
            }
            else
            {
                Console.WriteLine("Cuenta bloqueada por seguridad");
            }
        }
    }
}
