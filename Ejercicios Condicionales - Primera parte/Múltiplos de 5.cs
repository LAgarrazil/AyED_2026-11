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
            int edad1;
            int edad2;
            int diferencia;
            Console.Write("edad: ");
            edad1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("edad hermano");
            edad2 = Convert.ToInt32(Console.ReadLine());

            if (edad1 > edad2)
            {
                diferencia = (edad1 - edad2);
                Console.WriteLine("eres mayor que tu hermano por" + diferencia + "años");
            }   
            else
            {
                diferencia = (edad2 - edad1);
                Console.WriteLine("tu hermano es mayor que tu por" + diferencia + "años");
            } 
        }
    }
}