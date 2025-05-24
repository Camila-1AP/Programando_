using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perfecto();
        }
        static bool Perfecto()
        {
            Console.Write("Ingrese un número: ");
            string tryN = Console.ReadLine();

            bool exito1 = int.TryParse(tryN, out int numero);
            if (exito1)
            {
                int suma = 0;
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        suma += i;
                    }
                }
                return suma == numero;
            }
            return false;

        }
    }
}
