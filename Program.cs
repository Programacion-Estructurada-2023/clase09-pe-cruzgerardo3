using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
           
            Console.WriteLine("\n---Validador de Notas ---\n");

         Console.WriteLine("Ingrese la nota obtenida:");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 9.5)
            {
                Console.WriteLine("La calificación obtenida es Excelente");
            }
            else if (nota >= 8.5)
            {
                Console.WriteLine("La calificación obtenida es Muy Buena");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("La calificación obtenida es Buena");
            }
            else
            {
                Console.WriteLine("La calificación obtenida es Deficiente");
            }           
            Console.ReadKey();
        }
    }
}