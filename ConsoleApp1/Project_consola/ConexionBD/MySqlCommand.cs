namespace Project_consola.conexion
{
    internal class MySqlCommand
    {
        private string consulta;
        private object conexion;

        public MySqlCommand(string consulta, object conexion)
        {
            this.consulta = consulta;
            this.conexion = conexion;
        }
    }
}