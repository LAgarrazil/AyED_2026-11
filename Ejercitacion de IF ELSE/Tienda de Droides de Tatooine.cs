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
            int droide;
            int precio;
            int descuento;
            int total;
            Console.Write("cantidad de droides: ");
            droide = Convert.ToInt32(Console.ReadLine());
            precio = droide * 2000;
            if (droide >= 3)
            {
                descuento = (precio * 20) / 100;
                total = precio - descuento;
                Console.WriteLine("precio: " + precio );
                Console.WriteLine("descuento: " + descuento);
                Console.WriteLine("total: " + total);
            }
            else
            {
                Console.WriteLine("precio: " + precio);
            }

        }
    }
}
