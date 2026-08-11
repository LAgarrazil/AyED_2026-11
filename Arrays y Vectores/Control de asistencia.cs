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
            char[] clases = new char[20];
            int clase = 0;
            int asistencias = 0;
            int inasistencias = 0;
            for (int i = 0; i < clases.Length; i++)
            {
                clase++;
                Console.WriteLine("asistencia del alumno dia n°°: " + clase);
                clases[i] = Convert.ToChar(Console.ReadLine());
                if (clases[i] == 'A')
                {
                    asistencias++;
                }
                else if(clases[i] == 'I')
                {
                    inasistencias++;
                }
            }
            if (inasistencias >= 6)
            {
                Console.WriteLine("libre por faltas");
                Console.WriteLine("asistencias de alumno : " + asistencias);
                Console.WriteLine("faltas de alumno : " + inasistencias);
            }
            else if (asistencias >= 14)
            {
                Console.WriteLine("regular");
                Console.WriteLine("asistencias de alumno : " + asistencias);
                Console.WriteLine("faltas de alumno : " + inasistencias);
            }
        }
    }
}