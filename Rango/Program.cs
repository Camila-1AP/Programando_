using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rango
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rango();
        }
        // mostrar rango entre 2 números:
        static void Rango()
        {
            Console.Write("Ingrese el número de inicio del rango: ");
            string tryInicio = Console.ReadLine();
            bool exito1 = int.TryParse(tryInicio, out int inicio);

            Console.Write("Ingrese el número del final del rango: ");
            string tryFinal = Console.ReadLine();
            bool exito2 = int.TryParse(tryFinal, out int final);

            if (exito1 && exito2)
            {
                for (int i = inicio; i <= final; i++)
                {
                    Console.WriteLine($"N° {i} ");
                }
            }
        }
    }
}
