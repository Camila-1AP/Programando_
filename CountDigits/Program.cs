using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Digitos();
        }
        public static void Digitos()
        {
            Console.Write("Ingrese el número: ");
            string tryNumero = Console.ReadLine();

            bool exito = int.TryParse(tryNumero, out int numero);

            if (exito)
            {
                int count = 0;
                foreach (int i in tryNumero)
                {
                    count++;
                }
                Console.WriteLine($"La cantidad digitos del número {numero} es: {count}");
            }
        }
    }
}
