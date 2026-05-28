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
            Console.WriteLine("ingrese un numero entero: ");
            int numero = int.Parse(Console.ReadLine());
            int contador = 0;
            int multiplicacion = 0;
            while (contador <= 12)
            {
                    multiplicacion = multiplicacion = numero * contador;
                    Console.WriteLine("multiplo de " + contador + " = " + multiplicacion);
                    contador++;
            }


        }
    }
}
