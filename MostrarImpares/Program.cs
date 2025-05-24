using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImparWhile();
        }
        static void ImparWhile()
        {
            int count = 0;
            while (count < 100)
            {
                count++;
                if (count % 2 != 0)
                {
                    Console.WriteLine($" N° {count} ");
                    if (count == 99)
                    {
                        Console.WriteLine("Números impares del 1 - 100.");
                    }

                }

            }
        }
    }
}
