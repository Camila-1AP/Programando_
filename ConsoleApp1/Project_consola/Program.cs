using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Project_consola.conexion;
using System.Data;
using MySql.Data.MySqlClient;


namespace Project_consola
{
    internal class Program
    {
        static void Main()
        {
            ConexionBD conexionBD1 = new ConexionBD();
            conexionBD1.Conectar();
        }
       
    }
}

