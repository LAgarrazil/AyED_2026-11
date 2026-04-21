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
            int precio;
            int descuento;
            int total;
            Console.Write("total a pagar: ");
            precio = Convert.ToInt32(Console.ReadLine());
            if (precio >= 5000)
            {
                descuento = (precio * 15) / 100;
                total = precio - descuento;
                Console.WriteLine("precio: " + precio);
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