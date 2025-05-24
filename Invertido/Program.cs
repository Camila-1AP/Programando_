using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(InvertirCadena());
        }

        static string InvertirCadena()
        {
            Console.Write("Ingrese una palabra: ");
            string cadena = Console.ReadLine();
            char[] caracteres = cadena.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}
