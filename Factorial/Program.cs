using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial();
        }
        static void Factorial()
        {
            Console.Write("Ingrese el número: ");
            string tryFactorial = Console.ReadLine();
            bool exito1 = int.TryParse(tryFactorial, out int factorial);

            if (exito1)
            {
                int resultado = 1;
                for (int i = 1; i <= factorial; i++)
                {
                    resultado *= i;

                }
                Console.WriteLine($"Resultado: { resultado}");
            }

        }
    }
}
