using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdultoOmenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estado();
        }
        static void Estado()
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            string tryEdad = Console.ReadLine();

            bool exitoEdad = int.TryParse(tryEdad, out int edad);

            if (exitoEdad)
            {
                if (edad >= 18)
                {
                    Console.WriteLine($"{nombre} es mayor de edad. ");
                }
                else
                {
                    Console.WriteLine($"{nombre} no es mayor de edad. ");
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado debe ser entero positivo.");
            }
        }
    }
}
