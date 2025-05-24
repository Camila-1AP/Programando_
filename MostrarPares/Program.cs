using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParWhile();
        }
        static void ParWhile()
        {
            int count = 0;
            while (count < 100)
            {
                count++;
                if (count % 2 == 0)
                {
                    Console.WriteLine($" N° {count} ");
                    if (count == 100)
                    {
                        Console.WriteLine("Números pares del 1 - 100.");
                    }

                }

            }
        }
    }
}
