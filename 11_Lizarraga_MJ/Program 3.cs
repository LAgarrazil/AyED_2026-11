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


            Console.Write("año de nacimiento: ");
            int año = Convert.ToInt32(Console.ReadLine());

            int edad = 2026 - año;
           


            Console.Write("Si naciste en el año " + año + " tu edad al comenzar el año es de " + edad + " años.");
            

        }
    }
}
