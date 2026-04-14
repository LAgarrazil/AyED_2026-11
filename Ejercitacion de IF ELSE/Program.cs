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
            int peso;
            Console.Write("peso en la nave(kg): ");
            peso = Convert.ToInt32(Console.ReadLine());
            int pesosobrante = peso - 5000;
            if (peso <= 5000)
            {
                Console.WriteLine("Despegue autorizado. Buen viaje, Mando");
            }
            

            else
            {
                Console.WriteLine("Alerta: Exceso de peso. Debes descargar " + pesosobrante + " kg para despegar");
            }



        }
    }
}
