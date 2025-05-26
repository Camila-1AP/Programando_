using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EstadoNum();
        }
        static void EstadoNum()
        {
            Console.Write("Ingrese un número: ");
            string tryN = Console.ReadLine();

            bool exito1 = decimal.TryParse(tryN, out decimal numero);

            if (exito1)
            {
                if (numero > 1)
                {
                    Console.WriteLine( $"El número {numero} es positivo (+)");
                }
                else if (numero < 1 && numero != 0)
                {
                    Console.WriteLine( $"El número {numero} es negativo (-)");
                }
                else
                {
                    Console.WriteLine( $"El número {numero} es neutro (0)");
                }

            } else
            {
                Console.WriteLine($"El valor ingresado {tryN} no es valido.");
            }
               



        }
    }
}
