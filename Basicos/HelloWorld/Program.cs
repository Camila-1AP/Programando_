//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
// data  long = longnumberL, e.g.: long number = 900000L
//       double (float), e.g.: double number = 5.3D
// tipo de dato MinValue, MaxValue, son los valores minimos o maximos que puede almacenar cierto tipo de dato, e.g.: int.MinValue = -2147483648
// decimal, double, float, en orden de precisión 

//namespace HelloWorld
//static void Main(string[] args)

using System;

internal class Program
{
    static void Main()
    {
        // Bienvenida
        Console.WriteLine("Hello world!");
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();
        // string interpolation - Interporlaciones de cadena (Andir una palabra o fragmento en la transmisión de texto RAE)
        Console.WriteLine($"Bienvenido/a {nombre}! ");

        // Datos
        Console.Write("Ingrese un número para calcular su cuadrado: ");
        string user = Console.ReadLine();
        bool exito = int.TryParse(user, out int numero);


        Console.Write("Quieres sumar? ");
        string respuesta = Console.ReadLine();
        if (respuesta.ToLower() == "si" || respuesta.ToLower() == "sí")
        {
            Console.WriteLine("               | Sumemos |                   ");
            Console.Write("Ingrese el primer número: ");
            string numero1 = Console.ReadLine();
            bool exitoNum1 = int.TryParse(numero1, out int num1);

            Console.Write("Ingrese el segundo número: ");
            string numero2 = Console.ReadLine();
            bool exitoNum2 = int.TryParse(numero2, out int num2);

            if (exitoNum1 && exitoNum2)
            {
                Console.WriteLine($"La suma de los número {num1}, {num2}: {Sumar(num1, num2)} ");
            }
            else
            {
                Console.WriteLine("Error: Los valores ingresados deben ser numéricos.");
            }  

        }
        else
        {
            Console.WriteLine("No sumaremos dos números.");
        }

        if (exito)
        {
            Console.WriteLine($"EL cuadrado de {numero}: {Squard(numero)} ");
        }
        else
        {
            Console.WriteLine("Error: el valor ingresado debe ser numérico.");
        }

        // llamando a un método void, estos valores no serán utilizados
        Sumando();

    }
    public static int Sumar(int a, int b)
    {
        return a + b;
    }
    public static int Squard(int numero)
    {
        return numero * numero;
    }

    public static void Sumando()
    {
        Console.WriteLine("Sumando 3 números: ");
        Console.Write("Ingrese el primer número: ");
        string num1 = Console.ReadLine();
        bool exitoN1 = int.TryParse(num1, out int n1);

        Console.Write("Ingrese el segundo número: ");
        string num2 = Console.ReadLine();
        bool exitoN2 = int.TryParse(num1, out int n2);

        Console.Write("Ingrese el tercer número: ");
        string num3 = Console.ReadLine();
        bool exitoN3 = int.TryParse(num1, out int n3);

        if (exitoN1 && exitoN2 && exitoN3)
        {
            Console.WriteLine($"La suma de {n1}, {n2}, {n3}: {n1 + n2 + n3} ");
        }
        else
        {
            //cw + enter
            Console.WriteLine("Error: Todos los valores ingresados deben ser numéricos.");
            
        }
   


    }

  
     
}
