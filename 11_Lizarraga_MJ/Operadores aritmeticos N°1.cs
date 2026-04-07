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
            int a, b;
            Console.Write("ingrese un valor entero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese otro valor entero: ");
            b = Convert.ToInt32(Console.ReadLine());

            int resultadosuma;
            resultadosuma = a + b;
            Console.WriteLine("la suma de " + a + " + " + b + " = " + resultadosuma);

            int resultadoresta;
            resultadoresta = a - b;
            Console.WriteLine("la resta de " + a + " - " + b + " = " + resultadoresta);

            int resultadomultiplicacion;
            resultadomultiplicacion = a * b;
            Console.WriteLine("la multiplicacion de " + a + " x " + b + " = " + resultadomultiplicacion);

            double a2, b2;
            a2 = Convert.ToDouble(a);
            b2 = Convert.ToDouble(b);

            double resultadodivision = a2 / b2;
            Console.WriteLine("la division de " + a + " / " + b + " = " + resultadodivision);



        }
    }
}
