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
            Console.WriteLine("ingrese su contraseña: ");
            string contraseña = Console.ReadLine();
            do
            {
                if (contraseña != "soybatman")
                {
                    Console.WriteLine("error");
                    Console.WriteLine("ingrese su contraseña: ");
                    contraseña = Console.ReadLine();
                }
            } while (contraseña != "soybatman");
            Console.WriteLine("contraseña correcta");
        }
    }
}
