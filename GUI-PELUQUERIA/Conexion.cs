using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI_PELUQUERIA
{
    internal class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {
                cn= new SqlConnection("Data Source=.;Initial Catalog=Peluqueria;Integrated Security=True;TrustServerCertificate=True");
                cn.Open();
            }catch(Exception e) {
                MessageBox.Show("No se pudo conectar con la base de datos por: "+e.ToString());

            }
        }
        public String insertarH(String nom,double pre,String fec,String tipo,String marca)
        {
            String salida = "Herramienta registrada";
            try
            {
                cmd = new SqlCommand("insert into herramientas values ('"+nom+"',"+pre+",'"+fec+"','"+tipo+"','"+marca+"')",cn);
                cmd.ExecuteNonQuery();

            }catch(Exception e)
            {
                salida = "No se registro debiado a " + e.ToString();
                return salida;
            }
            return salida;
        }
        public int validarU(String us,String pw)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from usuario where nombre = '"+us+"' and contraseña = '"+pw+"'",cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }catch(Exception e)
            {
                MessageBox.Show("Error de conexion con la base de datos");
            }
            return contador;
        }
    }
}
