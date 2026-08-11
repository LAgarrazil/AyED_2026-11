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
            double[] nota = new double[10];
            double total = 0;
            int alumno = 0;
            int aprobados = 0;
            int desaprobados = 0;
            for (int i = 0; i < nota.Length; i++)
            {
                alumno++;
                Console.WriteLine("nota de alumno n°: " + alumno);
                nota[i] = Convert.ToDouble(Console.ReadLine());
                total += nota[i];
                if (nota[i] >= 6)
                {
                    aprobados++;
                }
                else 
                {
                    desaprobados++;
                }
            }
            double promedio = total / nota.Length;
            Console.WriteLine("alumnos aprobados: " + aprobados);
            Console.WriteLine("alumnos desaprobados: " + desaprobados);
            Console.WriteLine("promedio de notas: " + promedio);
        }
    }
}

