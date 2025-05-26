using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabla();
        }
        public static void Tabla()
        {
            Console.WriteLine("Ingrese un número para generar la tabla de multiplicar del 1 - 10: ");
            string tryN = Console.ReadLine();

            bool exito = int.TryParse(tryN, out int result);

            if (exito)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{result} * {i}  = {result * i}");
                }

            } else
            {
                Console.WriteLine("Ingrese valores validos.");
            }
            
        }
    }
}
