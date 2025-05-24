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
        }
        static bool Primo()
        {
            Console.Write("Ingrese un número: ");
            string tryPrimo = Console.ReadLine();

            bool exito1 = int.TryParse(tryPrimo, out int primo);

            if (exito1)
            {
                if (primo < 2) return false;
                for (int i = 2; i * i <= primo; i++)
                {
                    if (primo % i == 0) return false;
                }
                return true;
            }
            return false;
            
        }
       
    }
}
