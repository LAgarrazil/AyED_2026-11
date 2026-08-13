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
            int[] rifas = new int[15];
            int numero = 0;
            int rifa = 0;
            bool vendida = false;
            for (int i = 0; i < rifas.Length; i++)
            {
                rifa++;
                Console.WriteLine("numero de rifa vendida n°: " + rifa);
                rifas[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("rifa pedida: ");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < rifas.Length; i++)
            {
                if (rifas[i] == numero)
                {
                    vendida = true;
                }
            }
            if (vendida == true)
            {
                Console.WriteLine("rifa vendida");
            }
            else
            {
                Console.WriteLine("rifa disponible");
            }  
        }
    }
}