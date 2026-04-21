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
            int sueldo;
            int AñosAntiguedad;
            int aumento;
            int NuevoSueldo;
            Console.Write("sueldo: ");
            sueldo = Convert.ToInt32(Console.ReadLine());
            Console.Write("años de antiguedad: ");
            AñosAntiguedad = Convert.ToInt32(Console.ReadLine());
            if (AñosAntiguedad > 10)
            {
                aumento = (sueldo * 20) / 100;
                NuevoSueldo = sueldo + aumento;
                Console.WriteLine("nuevo sueldo: " + NuevoSueldo );
            }
            else
                aumento = (sueldo * 5) / 100;
                NuevoSueldo = sueldo + aumento;
                Console.WriteLine("nuevo sueldo: " + NuevoSueldo );
        }
    }
}