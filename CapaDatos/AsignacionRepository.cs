using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class AsignacionRepository
    {
        public void Crear(int idChofer, int idAutobus, int idRuta)
        {
            using (SqlConnection con = ConexionDB.Instancia.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_CrearAsignacion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdChofer", idChofer);
                cmd.Parameters.AddWithValue("@IdAutobus", idAutobus);
                cmd.Parameters.AddWithValue("@IdRuta", idRuta);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerAsignacionesActivas()
        {
            using (SqlConnection con = ConexionDB.Instancia.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerAsignacionesActivas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}