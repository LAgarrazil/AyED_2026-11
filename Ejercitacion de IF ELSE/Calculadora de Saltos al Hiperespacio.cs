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
            int AñosLuz;
            int Combustible;
            int CombustibleFaltante;
            Console.Write("distancia a recorrer(años luz): ");
            AñosLuz = Convert.ToInt32(Console.ReadLine());
            Console.Write("combustible actual(litros): ");
            Combustible = Convert.ToInt32(Console.ReadLine());
            CombustibleFaltante = AñosLuz * 12 - Combustible;
            if (Combustible >= AñosLuz * 12)
            {
                Console.WriteLine("Cálculos precisos. Saltando al hiperespacio");
            }
            else
            {
                Console.WriteLine("Peligro: Combustible insuficiente. Faltan " + CombustibleFaltante + " litros");
            }

        }
    }
}
