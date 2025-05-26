using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Runtime.InteropServices.WindowsRuntime;
using System.CodeDom; // este archivo contiene clases y metodos para manejar correctamente, numeros, monedas y conversiones

namespace Calculos // Agrupa clases relacionadas, permite que creemos varias clases con el mismo nombre siempre y cuando esten dentro de un namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Los miembros son la forma de estructurar nuestra clase y definen su comportamiento y acciones (variables, metodos...)
            // Se utiliza static en las funciones cuando no necesitan una instancia para funcionar, y no se utiliza cuando la función necesita de una instancia (objeto) para funcionar
            // Utilizamos Void en las funciones cuando no devuelven nada es decir no retornan nada y con esto nos referimos a que la función no utiliza return
            // En caso de que la función retorne algo, es decir utilice la palabra reservada return entonces, en lugar de void se utiliza el tipo de dato que devolverá


            Pangram("The quick brown fox jumps over the lazy dog.");
            //Console.Write("Ingrese un número del sistema Hexadecimal: ");
            //string hexVal = "4B0";
            //Console.WriteLine(hexVal);

            //string hexVal = Console.ReadLine().ToUpper(); // cultureInfo.InvariantCulture, permite que se realize una conversion estandar sin importar la fehca, hora o país
            //bool decValue = int.TryParse(hexVal, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int deciVal);
            //if (decValue)
            //{

            //    Console.WriteLine($"Converir {hexVal} al sistema decimal: ");
            //    Console.WriteLine(deciVal);

            //}
            //else
            //{
            //    Console.WriteLine("Error: el valor ingresado no es Hexadecimal.");
            //}


            //string pass = "Abcd1234";
            //Multiplicar();
            //Even();
            //fEven();
            //diccDate();
            //Password("Abcd1234");
            //Persistencia(27);
            Console.WriteLine(Mask("camilacamacho"));
            //CalcB();
            //DibujoT();
            Program p = new Program();
            p.Saludar("Camila");




        }
        static void Multiplicar()
        {
            
            int numTab = 0; // inicializar
            bool exito = false;

            while (!exito)
            {
                Console.Write("Ingrese un número para generar la tabla de multiplicar que desea: ");
                string numero = Console.ReadLine();
                exito = int.TryParse(numero, out numTab);

                if (!exito)
                {
                    Console.WriteLine("Error: El valor ingresado debe ser numérico. Intente nuevamente: ");

                }

            }
            
            Console.WriteLine("\n Tabla de multiplicar del ");
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numTab * i;
                Console.WriteLine($" {numTab} x {i} = {resultado} ");

            }     
        }

        
        static void Even()
        {
            List<int> even_numbers = new List<int>() { 1,2,6,4,9,34,84,29,10};
            List<int> lista_nueva = new List<int>();


            foreach (int numero in even_numbers)
            {
                if (numero % 2 == 0)
                {
                    lista_nueva.Add(numero);
                }
            }
            Console.WriteLine(lista_nueva.Sum());
        }

        // Programa que, recibe una lista de números, y suma solo aquellos que sean impares y muestra la suma.

        static void fEven()
        {
            List<int> noeven = new List<int>() {1,5,6,7,8,9,4,5,234,6,7,32,67 };
            HashSet<int> nuevaEven = new HashSet<int>();
            int nnEven = 0;

            foreach (int numero in noeven)
            {
                if (numero % 2 != 0)
                {
                    nuevaEven.Add(numero);
                    nnEven += numero;


                }
            }
            string result_noeven = String.Join(", ", noeven);
            string result_nuevaEven = String.Join(", ", nuevaEven);

            Console.WriteLine($"Hemos utilizado esta lista | {result_noeven} | de cual hemos extraído los impares | {result_nuevaEven} | cuya suma es | {nnEven} | ");
        }

        // Diccionario de datos

        static void diccDate()
        {
            Console.WriteLine("Welcome to the diccionary about names and email |");
            Dictionary<string, string> dicc_data = new Dictionary<string, string>();
            dicc_data.Add("Juan","juan@gmail.com");
            dicc_data.Add("Ana", "ana@gmail.com");
            dicc_data.Add("Lila", "lila@gmail.com");
            dicc_data.Add("William", "will@gmail.com");


            Console.Write("\n Mostrando el email de Lila | ");
            Console.Write(dicc_data["Lila"]);


        }
        
        static bool Password(string st)
        {
            if (st.Length < 8) return false;
            bool hasUpper = false, hasLower = false, hasDigit = false;

            foreach (char ch in st)
            {
                if (char.IsUpper(ch)) hasUpper = true;
                if (char.IsLower(ch)) hasLower = true;
                if (char.IsDigit(ch)) hasDigit = true;

                if (hasUpper && hasLower && hasDigit) return true;
            }
            return false;
            
            
            //return true;
        }
        // detectar si una frase es un Pagrama (frase que contiene letras de la A a la Z aunque sea una vez)

        static void Pangram(string str)
        {
            str = str.ToLower();
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                if (!str.Contains(ch))
                {
                    Console.WriteLine("Falso");
                }
            }
            Console.WriteLine("Verdadero");
          
        }
        static void Persistencia(long n) // cuantas veces se multiplico hasta llegar a un solo número
        {
            int count = 0;
            while (n >= 10)
            {
                long NewN = 1;
                while (n > 0)
                {
                    NewN *= n % 10;
                    n /= 10;
                }
                n = NewN;
                count++;
            }
             Console.WriteLine($"Result: {count} ");
        }
        // contraseña
        static string Mask(string cc)
        {
            if (cc.Length <= 4) return cc;
            int letter = cc.Length - 4;
            string four = cc.Substring(letter);
            string NewCC = new string('*', letter); // new string funciona como un bucle ya que convierte la cantidad de letter en *
            return NewCC + four;
        }
        // Si no se usase new string sería:
        //string mascara = "";
        //for (int i = 0; i<ultimas; i++) 
        //{
        //    mascara += "#";
        // }
        // return mascara + cc.Substring(ultimas);

        // CALCULADORA CON OPERACIONES BÁSICAS (SELECCIÓN)

        static void CalcB()
        {
            Console.WriteLine("Calculadora");

            Console.Write("Ingrese el primer número: ");
            string num1 = Console.ReadLine();
            bool exito1 = int.TryParse(num1, out int n1);
            Console.Write("Ingrese el segundo número: ");
            string num2 = Console.ReadLine();
            bool exito2 = int.TryParse(num2, out int n2);


            Console.Write(" Ingrese el signo de la operación correspondiente: + * - /  ");
            string signo = Console.ReadLine();
            if (signo == "+" && exito1 && exito2)
            {
                Console.WriteLine($"Suma: {n1} + {n2} = {n1 + n2} ");
            }if (signo == "-")
            {
                Console.WriteLine($"Resta: {n1} - {n2} = {n1 - n2} ");

            }if (signo == "*" && exito1 && exito2)
            {
                Console.WriteLine($"Multipliación: {n1} * {n2} = {n1 * n2} ");

            }if (signo == "/" && exito1 && exito2)
            {
                Console.WriteLine($"División: {n1} / {n2} = {n1 / n2} ");

            }

        }
        // DIBUJAR TRIÁNGULO
        static void DibujoT()
        {
            //Console.Write("Ingrese el valor que utilizará para dibujar: ");
            //string trazo = Console.ReadLine();
            //bool exito1 = int.TryParse(trazo, out int trazo1);


            //Console.Write("Ingrese el valor que indica el número de escalones: ");
            //string escalones = Console.ReadLine();
            //bool exito2 = int.TryParse(escalones, out int escalones1;


            int x = Convert.ToInt32(Console.ReadLine());
            int ancho = Convert.ToInt32(Console.ReadLine());
            int alto = ancho;

            for (int fila = 0; fila < alto; fila++)
            {
                for (int columna = 0; columna < ancho; columna++)
                {
                    Console.Write(x);
                }

                Console.WriteLine();
                ancho--;
            }
        }
        // Creando una función que requiere de una instancia (objeto) para poder ser llamada

        public void Saludar(string nombre)
        {
            Console.WriteLine($"Hello welcome {nombre} ");
        }





    }
}
