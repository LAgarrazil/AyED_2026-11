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
            int horas;
			int pago;
			int vuelto;
            Console.Write("horas en el estacionamiento: ");
            horas = Convert.ToInt32(Console.ReadLine());
            Console.Write("pago: ");
            pago = Convert.ToInt32(Console.ReadLine());
			int preciohora = 4000;
			int preciohorasextra = 1600;
			int total;
			
			if(horas == 1)
		    {
				vuelto = pago - preciohora;
				Console.WriteLine("dinero a pagar: " + preciohora);
				total = 4000;
				if (pago >= total)
				{
					Console.WriteLine("vuelto: " + vuelto);
				}
				else 
					Console.WriteLine("pago insuficiente");
			}
			
			else if (horas > 1 )
			{
				preciohorasextra = (horas * 1600) - 1600;
				total = preciohora + preciohorasextra;
				Console.WriteLine("dinero a pagar: " + total);
				vuelto = pago - total;
				if (pago >= total)
				{
					Console.WriteLine("vuelto: " + vuelto);
				}
				else
					Console.WriteLine("pago insuficiente");
			}
				
        }
    }
}
