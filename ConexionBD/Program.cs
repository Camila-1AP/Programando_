using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ConexionBD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConexionBD conexionBD1 = new ConexionBD();
            conexionBD1.Conectar();
        }
    }
}
