using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sustraccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Resta();

        }
        static void Resta()
        {
            Console.Write("Ingrese el primer número: ");
            string tryn1 = Console.ReadLine();
            bool exito1 = int.TryParse(tryn1, out int n1);

            Console.Write("Ingrese el segundo número: ");
            string tryn2 = Console.ReadLine();
            bool exito2 = int.TryParse(tryn2, out int n2);

            if (exito1 && exito2)
            {
                Console.WriteLine("Restando...");
                Thread.Sleep(2000);
                Console.WriteLine($"Resta: {n1} - {n2} = {n1 - n2} ");
            }

        }

    }
}
