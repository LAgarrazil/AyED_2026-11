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
            int facturas;
			int docenasvendidas;
			int precio;
			int total;
			int sobrante;
			int docenas;
            Console.Write("facturas producidas: ");
            facturas = Convert.ToInt32(Console.ReadLine());
            Console.Write("docenas vendidas: ");
            docenasvendidas = Convert.ToInt32(Console.ReadLine());
			Console.Write("precio docena: ");
            precio = Convert.ToInt32(Console.ReadLine());			
			if(facturas >= 12)
		    {
				docenas = facturas / 12;
				total = docenasvendidas * precio;
				Console.WriteLine("dinero recaudado: " + total);
				sobrante = facturas % 12;
				if (sobrante > 6)
				{
				    Console.WriteLine("Alerta: Exceso de producción");
				}
				else if (sobrante <= 6)
				{
					Console.WriteLine("Producción eficiente");
				}
			}
			
			else 
				Console.WriteLine("muy poca produccion");

				
        }
    }
}
