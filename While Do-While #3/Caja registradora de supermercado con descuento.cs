using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio;
            double subtotal = 0;

            do
            {
                Console.Write("Ingrese el precio del producto (0 para finalizar): ");
                precio = double.Parse(Console.ReadLine());

                if (precio > 0)
                {
                    subtotal += precio;
                }

            } while (precio != 0);

            double descuento = 0;

            if (subtotal > 15000)
            {
                descuento = subtotal * 0.10;
            }

            double totalFinal = subtotal - descuento;

            Console.WriteLine("Total: " + subtotal);
            Console.WriteLine("Descuento: " + descuento);
            Console.WriteLine("Total a pagar: " + totalFinal);
        }
    }
}
