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
            double altura;
            double peso;
            Console.Write("altura (m): ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("peso (kg): ");
            peso = Convert.ToDouble(Console.ReadLine());
            double imc = peso / (altura * altura);
            if (imc >= 25)
            {
                Console.WriteLine("sobrepeso");
            }

            else
                Console.WriteLine("rango normal");
        }
    }
}