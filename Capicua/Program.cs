using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capicua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invertido();
        }
        static void Invertido()
        {
            Console.Write("Ingrese un número: ");
            string tryCapicua = Console.ReadLine();
            bool exito = int.TryParse(tryCapicua, out int capicua);

            if (exito)
            {
                string original = capicua.ToString();
                char[] InvertidoArray = original.ToCharArray();
                Array.Reverse(InvertidoArray);
                string invertido = new string(InvertidoArray);
                if (original == invertido)
                {
                    Console.WriteLine("El número ingresado es Capicúa.");
                } else
                {
                    Console.WriteLine("El número ingresado no es Capicúa.");

                }

            }


        }
    }
}
