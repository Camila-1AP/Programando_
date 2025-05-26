using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SimulacionConexion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primero instalamos el paquete necesario para manejar base de datos
            Conexion conn = new Conexion();
            conn.Conectar();
        }
    }
}
