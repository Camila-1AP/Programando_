using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaUserPromedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese los números separados por coma (,): ");
            string input = Console.ReadLine();

        
            double[] numeros = input.Split(',').Select(n => double.Parse(n)).ToArray();

            double promedio = numeros.Average();

            Console.WriteLine($"El promedio de los números ingresados es: {promedio}");
        }
    }
}
