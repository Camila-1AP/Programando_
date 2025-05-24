using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bisiesto();
        }
        public static void Bisiesto()
        {
            Console.Write("Ingrese un año: ");
            string tryAño = Console.ReadLine();

            bool exito = int.TryParse(tryAño, out int año);

            if (exito)
            {
                if (año % 4 == 0)
                {
                    Console.WriteLine($"El año {año} es Bisiesto.");

                }
                else
                {
                    Console.WriteLine($"El año {año} no es Bisiesto.");
                }
            }
            else
            {
                Console.WriteLine("Ingrese valores válidos");
            }

        }
    }
}
