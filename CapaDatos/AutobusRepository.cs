using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class AutobusRepository
    {
        public void Insertar(string marca, string modelo, string placa, string color, int anio)
        {
            using (SqlConnection con = ConexionDB.Instancia.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarAutobus", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Marca", marca);
                cmd.Parameters.AddWithValue("@Modelo", modelo);
                cmd.Parameters.AddWithValue("@Placa", placa);
                cmd.Parameters.AddWithValue("@Color", color);
                cmd.Parameters.AddWithValue("@Anio", anio);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerDisponibles()
        {
            using (SqlConnection con = ConexionDB.Instancia.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarAutobusesDisponibles", con);
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
                SqlCommand cmd = new SqlCommand("sp_ObtenerTodosAutobuses", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
} 