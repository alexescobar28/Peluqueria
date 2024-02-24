using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;
namespace Capa_Datos
{
    public class ClaseDatos
    {
        SqlConnection pd = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_listar_productos()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_productos", pd);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_buscar_productos(ClaseEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_productos", pd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obje.nombreP);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public String D_mantenimiento_productos(ClaseEntidad obje)
        {
            String action = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_productos", pd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@numlote", obje.numLote);
            cmd.Parameters.AddWithValue("@nombre", obje.nombreP);
            cmd.Parameters.AddWithValue("@precio", obje.precio);
            cmd.Parameters.AddWithValue("@fechaCaducidad", obje.fechaCaducidad);
            cmd.Parameters.AddWithValue("@stockmin", obje.stockMin);
            cmd.Parameters.AddWithValue("@tipo", obje.tipo);
          
            cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = obje.action;
            cmd.Parameters["@action"].Direction = ParameterDirection.InputOutput;
            if (pd.State == ConnectionState.Open) pd.Close();
            pd.Open();
            cmd.ExecuteNonQuery();
            action = cmd.Parameters["@action"].Value.ToString();
            pd.Close();
            return action;

        }

    }



}
