using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Division();
        }
        static void Division()
        {
            Console.Write("Ingrese el primer número: ");
            string tryn1 = Console.ReadLine();
            bool exito1 = decimal.TryParse(tryn1, out decimal n1);
            
                
                try { 


                    Console.Write("Ingrese el segundo número: ");
                    string tryn2 = Console.ReadLine();
                    bool exito2 = decimal.TryParse(tryn2, out decimal n2);

                    if (exito1 && exito2)
                    {
                        
                        //Thread.Sleep(2000);
                        Console.WriteLine($"División: {n1} / {n2} = {n1 / n2} ");
                    }


                } catch (DivideByZeroException)
                {
                    Console.Write($"\nError: El denominador no debería ser cero.");
                }

            

        }
    }
}
