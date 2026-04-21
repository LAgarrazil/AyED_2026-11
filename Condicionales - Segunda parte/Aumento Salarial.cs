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
            int segundos;
            Console.Write("segundos: ");
            segundos = Convert.ToInt32(Console.ReadLine());
            int minutos = segundos / 60;
            int segundossobrantes = segundos % 60;
            if (segundos >= 60)
            {
                
                Console.WriteLine("minutos: " + minutos + "segundos" + segundossobrantes );
            }

            else
                Console.WriteLine("segundos: " + segundos );
        }
    }
}