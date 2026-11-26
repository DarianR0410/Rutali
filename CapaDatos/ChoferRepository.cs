using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ChoferRepository
    {
        public void Insertar(string nombre, string apellido, DateTime fechaNac, string cedula)
        {
            using (SqlConnection con = ConexionDB.Instancia.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarChofer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@FechaNac", fechaNac.Date);
                cmd.Parameters.AddWithValue("@Cedula", cedula);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerDisponibles()
        {
            using (SqlConnection con = ConexionDB.Instancia.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarChoferesDisponibles", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ObtenerTodos()
        {
            using (SqlConnection con = ConexionDB.Instancia.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerTodosChoferes", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}