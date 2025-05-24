using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci();
        }
        static void Fibonacci()
        {
            Console.Write("Ingrese el número: ");
            string tryNumero = Console.ReadLine();
            bool exito = int.TryParse(tryNumero, out int n);

            if (exito)
            {
                int a = 0, b = 1, temp;

                Console.WriteLine("Serie de Fibonacci:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(a + " ");
                    temp = a + b;
                    a = b;
                    b = temp;
                }
            }
            //if (n <= 1) return n;
            //int a = 0, b = 1, temp;
            //for (int i = 2; i <= n; i++)
            //{
            //    temp = a + b;
            //    a = b;
            //    b = temp;
            //}
            //return b;



        }
    }
}
