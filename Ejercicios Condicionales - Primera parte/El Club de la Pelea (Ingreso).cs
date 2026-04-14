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
            int edad;
            string nombre;
            Console.Write("edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("nombre: ");
            nombre = Console.ReadLine();
            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido al club, " + nombre);
            }
            else
            {
                Console.WriteLine("Lo siento, eres muy polluelo para esto");
            }
        }
    }
}
