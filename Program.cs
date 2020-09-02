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

            for (i = 0; i < 5; i++)
            {

                Console.WriteLine("Por favor, ingresar la primera nota del alumno.");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Por favor, ingresar la segunda nota del alumno.");
                n2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Por favor, ingresar la tercera nota del alumno.");
                n3 = Convert.ToDouble(Console.ReadLine());

                prom = (n1 + n2 + n3) / 3;

                Console.WriteLine("el promedio del alumno es de: {0} ", prom);

                if (prom >= 7 && prom <= 10)
                {
                    Console.WriteLine("El alumno aprobo la materia");
                }
                else
                {
                    if (prom >= 4 && prom <= 7)
                    {
                        Console.WriteLine("El alumno no aprobo, debe ir a diciembre");
                    }
                    else
                    {
                        if (prom >= 1 && prom <= 4)
                        {
                            Console.WriteLine("El alumno no aprobo, debe ir a febrero");

                            
                        }
                    }
                }
               
                Console.ReadKey();
            }

        }

    }


}

