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
            Console.Write("Ingrese un numero entero: ");
            int numero = int.Parse(Console.ReadLine());

            if (Capicua(numero))
            {
                Console.WriteLine("Es capicua.");
            }
            else
            {
                Console.WriteLine("No es capicua.");
            }
        }

        static bool Capicua(int numero)
        {
            if (numero < 0)
            {
                numero = numero * -1;
            }

            int copia = numero;
            int invertido = 0;

            while (copia > 0)
            {
                int digito = copia % 10;
                invertido = invertido * 10 + digito;
                copia = copia / 10;
            }

            return numero == invertido;
        }
    }
}
