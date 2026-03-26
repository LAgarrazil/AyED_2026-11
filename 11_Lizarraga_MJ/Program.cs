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
            string pelicula;

            Console.Write("pelicula favorita: ");
            pelicula = Console.ReadLine();


            Console.WriteLine("Hola " + nombre + ". Tu pelicula preferida " + pelicula + " es una porqueria");
            

        }
    }
}
