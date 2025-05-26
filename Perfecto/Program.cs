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
        static void Perfecto()
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
                if (suma == numero)
                {
                    Console.WriteLine("Es Perfecto!");


                } else
                {
                    Console.WriteLine("El número no es perfecto");
                }
                   
            }
            

        }
    }
}
