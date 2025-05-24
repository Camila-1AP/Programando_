using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mayor();
        }
        static void Mayor()
        {
            Console.WriteLine("Ingrese el primer número: ");
            string tryN1 = Console.ReadLine();
            bool exito1 = int.TryParse(tryN1, out int A);


            Console.WriteLine("Ingrese el segundo número: ");
            string tryN2 = Console.ReadLine();
            bool exito2 = int.TryParse(tryN2, out int B);


            Console.WriteLine("Ingrese el primer número: ");
            string tryN3 = Console.ReadLine();
            bool exito3 = int.TryParse(tryN3, out int C);

            if (exito1 && exito2 && exito3)
            {
                if (A > B && A > C)
                {
                    Console.WriteLine($"El número mayor es {A}");
                }
                else if (B > A && B > C)
                {
                    Console.WriteLine($"El número mayor es {B}");
                }
                else
                {
                    Console.WriteLine($"El número mayor es {C}");

                }
            }
        }
    }
}
