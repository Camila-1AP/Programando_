using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.AccessControl;

namespace Project_consola.conexion
{
    class ConexionBD
    {

        private string conexionStr = "server=localhost; database=proyecto_consola; user=root; password=290515";

        public void Conectar()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionStr))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("La conexión a la base de datos ha sido satisfactoria!");

                    // consultas
                    // -- ADD
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Apellido: ");
                    string apellido = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Fecha de nacimiento: ");
                    string fechaNacimiento = Console.ReadLine();

                    Console.Write("Número de teléfono: ");
                    string numTel = Console.ReadLine();

                    string consultaADD = "INSERT INTO usuarios (nombre, apellido, email, fecha_nacimiento, numero_tel)" + "VALUES (@nombre, @apellido, @email, @fecha_nacimiento, @numero_tel)";

                    using (MySql.Data.MySqlClient.MySqlCommand comandoADD = new MySql.Data.MySqlClient.MySqlCommand(consultaADD, conexion))
                    {
                        comandoADD.Parameters.AddWithValue("@nombre", nombre);
                        comandoADD.Parameters.AddWithValue("@apellido", apellido);
                        comandoADD.Parameters.AddWithValue("@email", email);
                        comandoADD.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento);
                        comandoADD.Parameters.AddWithValue("@numero_tel", numTel);

                        int registroADD = comandoADD.ExecuteNonQuery();
                        Console.WriteLine(registroADD > 0 ? "El registro ha sido guardado satisfactoriamente!" : "Error de registro"); // operación ternaria

                    }
                } catch (Exception ex)
                {
                    Console.Write($"Error: {ex}");
                }
                

            }
        }
        
    }

}




