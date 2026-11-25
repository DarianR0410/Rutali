using System.Data.SqlClient;

namespace CapaDatos
{
    public class ConexionDB
    {
        private static ConexionDB _instancia;
        private readonly string cadenaConexion = "Server=.;Database=SistemaAutobusesDB;Integrated Security=true;";

        private ConexionDB() { }

        public static ConexionDB Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ConexionDB();
                }
                return _instancia;
            }
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}