using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_Lizarraga_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola ususario");
            string nombre;
            
            Console.Write("cual es tu nombre: ");
            nombre = Console.ReadLine();
            string juego;

            Console.Write("juego favorito: ");
            juego = Console.ReadLine();
            string consola;

            Console.Write("consola en la que jugas: ");
            consola = Console.ReadLine();


            Console.WriteLine("Hola " + nombre + ". Tu juego favorito es " + juego + " y se juega en " + consola);
            

        }
    }
}
