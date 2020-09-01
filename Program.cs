using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicagit
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, prom, i = 0;

            Console.WriteLine("Por favor, ingrese la primera nota del alumno.");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor, ingrese la segunda nota del alumno.");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor, ingrese la tercera nota del alumno.");
            n3 = Convert.ToDouble(Console.ReadLine());

            prom = (n1 + n2 + n3) / 3;

            Console.WriteLine("el promedio es de: {0} ", prom);


            Console.ReadKey();

        }
    }
}
