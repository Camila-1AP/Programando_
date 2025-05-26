using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Primo();
        }
        static void Primo()
        {
            Console.Write("Ingrese un número: ");
            string tryPrimo = Console.ReadLine();

            bool exito1 = int.TryParse(tryPrimo, out int primo);

            if (exito1)
            {
                if (primo < 2)
                {
                    Console.WriteLine("El número no es primo");
                }

                for (int i = 2; i * i <= primo; i++)
                {
                    if (primo % i == 0)
                    {
                        Console.WriteLine("El número no es primo");
                    } else
                    {
                        Console.WriteLine("El número es primo!");
                    }
                   
                }
                
                //Console.WriteLine("El número es primo!");
            }else
            {
                Console.WriteLine("El número no es primo");
            }
                
            
        }
       
    }
}
