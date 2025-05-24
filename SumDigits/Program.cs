using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            SumDigitos();
        }
        static void SumDigitos()
        {
            Console.Write("Ingrese el número: ");
            string tryN = Console.ReadLine();
            //bool exito = int.TryParse(tryN, out int numero);


            int suma = 0;
            foreach (char i in tryN)
            {
               bool exito = int.TryParse(i.ToString(), out int numero);
               if (exito)
               {
                   suma += numero;

               }     
            }     
            Console.WriteLine($"La suma de los dígitos del número ingresado es {suma} ");
            

        }
    }
}
