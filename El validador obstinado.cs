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
            Console.WriteLine("ingrese su nota: ");
            int nota = int.Parse(Console.ReadLine());
            do
            { 
                if(nota < 1 || nota > 10)
                {
                    Console.WriteLine("error");
                    Console.WriteLine("ingrese su nota: ");
                    nota = int.Parse(Console.ReadLine());
                }
            } while (nota < 1 || nota > 10);
            Console.WriteLine("nota: " + nota);
        }
    }
}
