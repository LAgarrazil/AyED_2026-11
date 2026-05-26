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
            Console.WriteLine("saludar");
            Console.WriteLine("despedirse");
            Console.WriteLine("salir");
            Console.WriteLine("ingrese una opcion: ");
            string opcion = Console.ReadLine();
            do
            {
                if (opcion == "saludar")
                {
                    Console.WriteLine("hola");
                    Console.WriteLine("saludar");
                    Console.WriteLine("despedirse");
                    Console.WriteLine("salir");
                    Console.WriteLine("ingrese una opcion: ");
                    opcion = Console.ReadLine();
                }
                else if (opcion == "despedirse")
                {
                    Console.WriteLine("chau");
                    Console.WriteLine("saludar");
                    Console.WriteLine("despedirse");
                    Console.WriteLine("salir");
                    Console.WriteLine("ingrese una opcion: ");
                    opcion = Console.ReadLine();
                }
                Console.WriteLine("opcion invalida");

            } while (opcion == "saludar" || opcion == "despedirse" || opcion == "salir");

        }
    }
}