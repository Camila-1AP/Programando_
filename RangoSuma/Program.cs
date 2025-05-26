using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoSuma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RangoSuma();
        }
        // mostrar la suma del rango entre dos números

        static void RangoSuma()
        {
            Console.Write("Ingrese el número de inicio del rango: ");
            string tryInicio = Console.ReadLine();
            bool exito1 = int.TryParse(tryInicio, out int inicio);

            Console.Write("Ingrese el número del final del rango: ");
            string tryFinal = Console.ReadLine();
            bool exit2 = int.TryParse(tryFinal, out int final);

            if (exito1 && exit2)
            {
                int suma = 0;
                for (int i = inicio; i <= final; i++)
                {
                    suma += i;

                }
                Console.WriteLine($"La suma de todos los números dentro del rango del {inicio} - {final} = {suma}");
            }
        }
    }
}
