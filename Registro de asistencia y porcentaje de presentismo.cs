using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int presentes = 0;
            int ausentes = 0;
            string respuesta;

            do
            {
                Console.Write("Ingrese el nombre del alumno: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el estado (P = Presente, A = Ausente): ");
                string estado = Console.ReadLine();

                if (estado == "P" || estado == "p")
                {
                    presentes++;
                }
                else if (estado == "A" || estado == "a")
                {
                    ausentes++;
                }

                Console.Write("¿Desea cargar otro alumno? (S/N): ");
                respuesta = Console.ReadLine();

            } while (respuesta == "S" || respuesta == "s");

            int total = presentes + ausentes;
            double porcentaje = 0;

            if (total > 0)
            {
                porcentaje = presentes * 100 / total;
            }

            Console.WriteLine();
            Console.WriteLine("Cantidad de presentes: " + presentes);
            Console.WriteLine("Cantidad de ausentes: " + ausentes);
            Console.WriteLine("Porcentaje de presentes: " + porcentaje);
        }
    }
}
