﻿using System;
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
            
            double n1, n2, n3, prom,i=0;
            
            for(i=0;i<4;i++)
            {

            Console.WriteLine("Por favor, ingrese la primera nota del alumno.");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor, ingrese la segunda nota del alumno.");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor, ingrese la tercera nota del alumno.");
            n3 = Convert.ToDouble(Console.ReadLine());

            prom = (n1 + n2 + n3) / 3;

            Console.WriteLine("el promedio es de: {0} ", prom);

                if(n1>=7 && n1<=10)
                {
                    Console.WriteLine("El alumno aprobo la materia, Felicitaciones.");
                }
                else
                {
                    if (n1 >= 4 && n1 <= 7)
                    {
                        Console.WriteLine("El alumno no aprobo la materia, debera ir a mesa de examen en diciembre.");
                    }
                }
            }

            Console.ReadKey();
            
        }
    }
}
