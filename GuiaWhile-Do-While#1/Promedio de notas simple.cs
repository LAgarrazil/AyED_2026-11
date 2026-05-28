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
            double nota;
            double total = 0;
            double promedio;
            int alumnos = 0;

            do
            {
                Console.WriteLine("Ingrese nota del alumno:");
                nota = Convert.ToDouble(Console.ReadLine());

                if (nota >= 0 && nota <= 10)
                {
                    total += nota;
                    alumnos++;
                }

            } while (alumnos < 5);

            promedio = total / alumnos;

            Console.WriteLine("Promedio de notas: " + promedio);
        }
    }
}
