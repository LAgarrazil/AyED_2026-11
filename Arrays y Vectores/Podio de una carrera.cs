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
            int estrella1 = 0;
            int estrella2 = 0;
            int estrella3 = 0;
            int estrella4 = 0;
            int estrella5 = 0;
            int[] calificaciones = new int[5];
            int calificacion = 0;
            string opcion = "0";
            for (int i = 0; i < calificaciones.Length; i++)
            {
                calificacion++;
                Console.WriteLine("calificacion cliente n°: " + calificacion);
                calificaciones[i] = Convert.ToInt32(Console.ReadLine());
            }
            switch (opcion)
            {
                case "1":
                    estrella1++;
                    break;

                case "2":
                    estrella2++;
                    break;

                case "3":
                    estrella3++;
                    break;

                case "4":
                    estrella4++;
                    break;

                case "5":
                    estrella5++;
                    break;

                default:
                    Console.WriteLine("reseña invalida");
                    break;

            Console.WriteLine("reseñas de 1 estrella" + estrella1);
            Console.WriteLine("reseñas de 2 estrella" + estrella2);
            Console.WriteLine("reseñas de 3 estrella" + estrella3);
            Console.WriteLine("reseñas de 4 estrella" + estrella4);
            Console.WriteLine("reseñas de 5 estrella" + estrella5);
            }
        }
    }
}
