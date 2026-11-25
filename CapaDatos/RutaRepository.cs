using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class RutaRepository
    {
        public void Insertar(string nombreRuta)
        {
            using (SqlConnection con = ConexionDB.Instancia.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarRuta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreRuta", nombreRuta);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerDisponibles()
        {
            using (SqlConnection con = ConexionDB.Instancia.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarRutasDisponibles", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ObtenerTodas()
        {
            using (SqlConnection con = ConexionDB.Instancia.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerTodasRutas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}