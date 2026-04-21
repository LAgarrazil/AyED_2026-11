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
            int presupuesto;
            int costo;
            int diferencia;
            Console.Write("presupuesto: ");
            presupuesto = Convert.ToInt32(Console.ReadLine());
            Console.Write("ecosto: ");
            costo = Convert.ToInt32(Console.ReadLine());

            if (costo > presupuesto)
            {
                diferencia = (costo - presupuesto);
                Console.WriteLine("pedir un prestamo por " + diferencia);
            }   
            else
            {
                Console.WriteLine("pueede proceder con la obra");
            } 
        }
    }
}