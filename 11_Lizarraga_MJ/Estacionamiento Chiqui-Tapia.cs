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
            int minutos;
            Console.Write("minutos en el estacionamiento: ");
            minutos = Convert.ToInt32(Console.ReadLine());
            int PrecioHoras = 6000;
            int PrecioMinutos = 150;

            int HorasEstacionado = minutos / 60;
            Console.WriteLine("horas: " + HorasEstacionado);

            int MinutosEstaciuonado = minutos % 60;
            Console.WriteLine("minutos: " + MinutosEstaciuonado);

            int total = MinutosEstaciuonado * PrecioMinutos + HorasEstacionado * PrecioHoras;

            int iva = total * 21 / 100;
            Console.WriteLine("IVA: " + iva);

            int final = total + iva;
            Console.WriteLine("total a pagar: " + final);



        }
    }
}
