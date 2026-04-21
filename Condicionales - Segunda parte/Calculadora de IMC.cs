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
            string genero;
            int edad;
            Console.Write("genero (m o f): ");
            genero = Console.ReadLine();
            Console.Write("edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            if (genero == "f" & edad >= 60)
            {
                Console.WriteLine("Puede iniciar el trámite jubilatorio");
            }
            else if (genero == "m" & edad >= 65)
            {
                Console.WriteLine("Puede iniciar el trámite jubilatorio");
            }
            else
                Console.WriteLine("no puede iniciar el trámite jubilatorio");
        }
    }
}