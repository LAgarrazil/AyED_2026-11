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
            int opcion;
            Console.WriteLine("1.Ingles");
            Console.WriteLine("2.Frances");
            Console.WriteLine("3.Aleman");
            Console.Write("Opcion deseada: ");
            opcion = Convert.ToInt32(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    Console.WriteLine("hello");
                    break;


                case 2:
                    Console.WriteLine("salut");
                    break;

                case 3:
                    Console.WriteLine("hallo");
                    break;

                default:
                    Console.WriteLine("idioma no detectado");
                    break;
            }
        }
    }
}