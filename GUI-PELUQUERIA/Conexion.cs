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
        SqlDataAdapter da;
        DataTable dt;

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
        public int validarH(String nom)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from herramientas where nombreH = '" + nom + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexion con la base de datos");
            }
            return contador;
        }
        public void llenarCH(String nom,TextBox tp,DateTimePicker f,ComboBox es,TextBox m)
        {
            try
            {
                cmd = new SqlCommand("select * from herramientas where nombreH='"+nom+"'",cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tp.Text = dr["precio"].ToString();
                    f.Text = dr["fechaAdqui"].ToString();
                    es.Text = dr["tipo"].ToString();
                    m.Text = dr["marca"].ToString();
                }
                dr.Close ();
            }catch(Exception ex)
            {
                MessageBox.Show("Error de llenado de datos por: "+ex.ToString());
            }
        }
        public String insertarU(String us,String pw)
        {
            String salida = "Usuario registrado";
            try
            {
                cmd = new SqlCommand("insert into usuario values ('"+us+"','"+pw+"')",cn);
                cmd.ExecuteNonQuery ();
            }
            catch (Exception e)
            {
                salida = "No se registro usuario debido a: "+e.ToString();
            }
            return salida;
        }
        public String actualizarU(String us,String pw)
        {
            String salida = "Usuario actualizado";
            try
            {
                cmd = new SqlCommand("update usuario set contraseña='"+pw+"' where nombre='"+us+"'",cn);
                cmd.ExecuteNonQuery();
            }catch (Exception e)
            {
                salida = "No se actualizo usuario debido a: " + e.ToString();
            }
            return salida;
        }
        public String actualizarH(String nom,String est)
        {
            String salida = "Herramienta actualizado";
            try
            {
                cmd = new SqlCommand("update herramientas set tipo='" + est + "' where nombreH='" + nom + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                salida = "No se actualizo herramienta debido a: " + e.ToString();
            }
            return salida;
        }
        public String eliminarU(String us)
        {
            String salida = "Usuario elimindao";
            try
            {
                cmd = new SqlCommand("delete from usuario where nombre='"+us+"'",cn);
                cmd.ExecuteNonQuery();
            }catch (Exception e)
            {
                salida = "No se elimino usuario debido a: " + e.ToString();
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
        public void llenarT(String t,DataGridView dgv)
        {
            String con = "select * from " + t;
            try
            {
                da = new SqlDataAdapter(con,cn);
                dt=new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }catch(Exception e)
            {
                MessageBox.Show("No se pudo llenar la tabla por: "+e.ToString());
            }
        }
        public void llenarConsultaU(String us,TextBox tc)
        {
            try
            {
                cmd = new SqlCommand("select * from usuario where nombre='"+us+"'",cn);
                dr=cmd.ExecuteReader();
                if (dr.Read())
                {
                    tc.Text = dr["contraseña"].ToString();
                }
                dr.Close ();
            }
            catch(Exception e)
            {
                MessageBox.Show("No se pudo realizar la consulto por: "+e.ToString());
            }
        }
        public int validarCU(String us)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from usuario where nombre = '" + us + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexion con la base de datos");
            }
            return contador;
        }
        public void llenarPara(TextBox i,TextBox m)
        {
            try
            {
                cmd = new SqlCommand("select * from parametros where nombre='IVA'",cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    i.Text = dr["valor"].ToString();
                }
                dr.Close();
                cmd = new SqlCommand("select * from parametros where nombre='moneda'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    m.Text = dr["valor"].ToString();
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo cargar los datos por: " + e.ToString());
            }
        }
        public void llenarIVA(TextBox iva)
        {
            try
            {
                cmd = new SqlCommand("select * from parametros where nombre='IVA'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    iva.Text = dr["valor"].ToString();
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo cargar los datos por: " + e.ToString());
            }
        }
        public String actualizarP(String q,String v)
        {
            String salida = "Parametro actualizado";
            String act = "update parametros set valor='" + v + "' where nombre ='" + q + "'";
            try
            {
                cmd = new SqlCommand(act,cn);
                cmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                salida = "No se pudo actualizar parametro por: "+e.ToString();
            }
            return salida;
        }
        public int validarP(String nom)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from productos where nombreP = '" + nom + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexion con la base de datos");
            }
            return contador;
        }
        public int validarFID()
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select * from factura", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexion con la base de datos");
            }
          
            return contador;
        }
        public String insertarFac(String ced,String fec,String cos)
        {
            String salida = "Factura registrada";
            try
            {
                cmd = new SqlCommand("insert into factura (cedula,fecha,costo)values ('" + ced + "','" + fec + "','"+cos+"')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                salida = "No se registro factura debido a: " + e.ToString();
            }
            return salida;
        }
        public void insertIt(int idf,String nom,String can,String cost)
        {
            try
            {
                cmd = new SqlCommand("insert into item values ('"+idf+"','"+nom+"','"+can+"','"+cost+"')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se registro item debido a: " + e.ToString());
            }
        }
        public void llenarPT(String nom,DataGridView dgv)
        {
            String con = "select nombreP as 'Nombre de producto',sum(cantidad) as 'cantidad Total' from productos where nombreP='"+nom+"' group by nombreP";
            try
            {
                da = new SqlDataAdapter(con, cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo llenar la tabla por: " + e.ToString());
            }
        }
        public void actINV(String nom,int cant)
        {
            try
            {
                cmd = new SqlCommand("delete from productos where cantidad=0", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("error eliminacion" + e.ToString());
            }
            try
            {
                cmd = new SqlCommand("select top 1 * from productos where nombreP='"+nom+"'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (cant > int.Parse(dr["cantidad"].ToString()))
                    {
                        String aux = dr["numlote"].ToString();
                        cant = cant - int.Parse(dr["cantidad"].ToString());
                        dr.Close();
                        cmd = new SqlCommand("update productos set cantidad=0 where numlote='"+aux+"'", cn);
                        cmd.ExecuteNonQuery();
                        actINV(nom, cant);
                    }
                    else
                    {
                        String aux = dr["numlote"].ToString();
                        cant = int.Parse(dr["cantidad"].ToString())-cant;
                        dr.Close();
                        cmd = new SqlCommand("update productos set cantidad='"+cant+"' where numlote='" + aux + "'", cn);
                        cmd.ExecuteNonQuery();
                    }
                    
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error eliminacion" + e.ToString());
            }
        }
    }
}
