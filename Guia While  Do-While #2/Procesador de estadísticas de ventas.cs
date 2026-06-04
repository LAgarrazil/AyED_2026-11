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
            double totalRecaudado = 0;
        int cantidadVentas = 0;
        double ventaMasAlta = 0;
        char continuar;

        do
        {
            Console.Write("Ingrese el monto de la venta: ");
            double venta = Convert.ToDouble(Console.ReadLine());

            totalRecaudado += venta;
            cantidadVentas++;

            if (venta > ventaMasAlta)
            {
                ventaMasAlta = venta;
            }

            Console.Write("Desea ingresar otra venta (S/N): ");
            continuar = Convert.ToChar(Console.ReadLine());

        } while (continuar == 'S' || continuar == 's');

        Console.WriteLine("Total recaudado: " + totalRecaudado);
        Console.WriteLine("Cantidad de ventas: " + cantidadVentas);
        Console.WriteLine("Venta mas alta: " + ventaMasAlta);
            
        }
    }
}
