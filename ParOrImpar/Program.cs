using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOrImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParImpar();
        }
        static void ParImpar()
        {
            Console.Write("Ingrese un número: ");
            string tryN = Console.ReadLine();
            bool exito1 = int.TryParse(tryN, out int numero);

            if (exito1)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"El número {numero} es par.");
                }
                Console.WriteLine($"El número {numero} es impar.");
            }
        }
    }
}
