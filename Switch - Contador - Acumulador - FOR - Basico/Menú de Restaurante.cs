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
            string opcion;
            Console.WriteLine("S.Sandwich");
            Console.WriteLine("P.Pizza");
            Console.WriteLine("H.Hamburguesa");
            Console.Write("Opcion deseada: ");
            opcion = Console.ReadLine();


            switch (opcion)
            {
                case "S":
                    Console.WriteLine("sandwich");
                    break;


                case "P":
                    Console.WriteLine("pizza");
                    break;

                case "H":
                    Console.WriteLine("hamburguesa");
                    break;

                default:
                    Console.WriteLine("producto no encontrado");
                    break;
            }
        }
    }
}