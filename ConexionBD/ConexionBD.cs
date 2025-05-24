using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace ConexionBD
{
    public class ConexionBD
    {
        private string conexionSTR = "server=localhost; database=proyecto_consola; user=root; password=290515";

        public void Conectar()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionSTR))
                {
                    conexion.Open();
                    Console.WriteLine("La conexión a la base de datos ha sido satisfactoria! ");

                    Console.Write("Nombre: "); 
                    string nombre = Console.ReadLine();

                    Console.Write("Apellido: ");
                    string apellido = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Fecha de nacimiento: ");
                    string fecha_nacimiento = Console.ReadLine();

                    Console.Write("Número de teléfono: ");
                    string numTel = Console.ReadLine();

                    // consultas
                    // ADD
                    string consultaADD = "INSERT INTO usuarios (nombre, apellido, email, fecha_nacimiento, numero_tel)" + "VALUES (@nombre, @apellido, @email, @fecha_nacimiento, @numero_tel)";
                    using (MySql.Data.MySqlClient.MySqlCommand comandoADD = new MySql.Data.MySqlClient.MySqlCommand(consultaADD, conexion))
                    {
                        comandoADD.Parameters.AddWithValue("@nombre", nombre);
                        comandoADD.Parameters.AddWithValue("@apellido", apellido);
                        comandoADD.Parameters.AddWithValue("@email", email);
                        comandoADD.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
                        comandoADD.Parameters.AddWithValue("@numero_tel", numTel);

                        int registrosADD = comandoADD.ExecuteNonQuery();
                        Console.WriteLine(registrosADD > 0 ? $"\nEl registro de {nombre} ha sido satisfactorio!": "\nError de registro.");
                    }
                }

            }catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }
    }
}
