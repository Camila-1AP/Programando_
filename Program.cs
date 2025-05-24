using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
 
// repositorio de git hub, crear 

// mover cada funcion a un proyecto distinto



// EJERCICIO
// Desde una aplicación de consola debo agregar una persona a la base de datos. Le pida a la persona 5 datos y luego se registren en la base de datos
// Nombre, Apellido,email, fecha_nacimiento, numero_tel




namespace Adicion
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // como compilar

            //log de errores
            // compilar (compila lo ultimo actualizado)
            //limpiar (limpia el archivo binario)

            Adicion();
        }
        static void Adicion()
        {
            Console.Write("Ingrese el primer número: ");
            string tryn1 = Console.ReadLine();
            int exito1 = int.Parse(tryn1);

            Console.Write("Ingrese el segundo número: ");
            string tryn2 = Console.ReadLine();
            int exito2 = int.Parse(tryn2);
            Console.WriteLine($"Suma: {exito1} + {exito2} = {exito1 + exito2} ");
        }
        

        


    }
}
