using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SimulacionConexion
{
    internal class Conexion
    {
        // 
        private string conexionSTR = "server=localhost; database=proyecto_consola; user=root; password=290515";
        UTF8Encoding encoding;
        public void Conectar()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionSTR))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("La conexión a la base de datos ha sido satisfactoria!");

                    // Consultas
                    // ADD
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Apellido: ");
                    string apellido = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Fecha de nacimiento: ");
                    string fechaNacimiento = Console.ReadLine();

                    Console.Write("Número de teléfono: ");
                    string numeroTel = Console.ReadLine();

                    // consulta ADD

                    string consultaADD = "INSERT INTO usuarios (nombre, apellido, email, fecha_nacimiento, numero_tel)" + "VALUES (@nombre, @apellido, @email, @fecha_nacimiento, @numero_tel)";
                    // comando ADD
                    using (MySql.Data.MySqlClient.MySqlCommand comandoADD = new MySql.Data.MySqlClient.MySqlCommand(consultaADD, conexion))
                    {
                        comandoADD.Parameters.AddWithValue("@nombre", nombre);
                        comandoADD.Parameters.AddWithValue("@apellido", apellido);
                        comandoADD.Parameters.AddWithValue("@email", email);
                        comandoADD.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento);
                        comandoADD.Parameters.AddWithValue("@numero_tel", numeroTel);

                        // evaluamos si ha resgistrado 
                        int registros = comandoADD.ExecuteNonQuery();
                        Console.WriteLine(registros > 0 ? $"\nEl {nombre} se ha registrado satisfactoriamente!" : "Error de registro"); // operacion ternaria
                    }


                } catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex}");
                }
                

            }
            // datafridView.Rows.Add(text1.Text, textt2.Text); Agrega datos al Data Grid

        }
    }
}
