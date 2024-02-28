using Capa_Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
namespace Capa_Datos
{
    public class Cd_Usuarios
    {
        public List<Usuario> listar()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection oconexon = new SqlConnection(Conexion_Cp.cadena))
            {
                try
                {
                    string query = "select idUsuario,nombre,contraseña from usuario";
                    SqlCommand cmd = new SqlCommand(query, oconexon);
                    cmd.CommandType = CommandType.Text;
                    oconexon.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                idUsuaro = Convert.ToInt32(dr["idUsuario"]),
                                nombre = dr["nombre"].ToString(),
                                contraseña = dr["contraseña"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();

                }
                return lista;
            }
        }

        public  int Registrar(Usuario obje,out string Mensaje)
        {
        
                int idusuariogenerado = 0; 
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexon = new SqlConnection(Conexion_Cp.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", oconexon);
                    cmd.Parameters.AddWithValue("Nomusuario", obje.nombre);
                    cmd.Parameters.AddWithValue("Contrasenia", obje.contraseña);
                    cmd.Parameters.Add("IdUsuarioResultado",SqlDbType.Int).Direction=ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje",SqlDbType.VarChar, 500).Direction=ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexon.Open();
                    cmd.ExecuteNonQuery();
                    idusuariogenerado = Convert.ToInt32(cmd.Parameters["IdUsuarioResultado"].Value);
                    Mensaje = cmd.Parameters["Mesaje"].Value.ToString();

                }
               
            }
            catch (Exception ex)
            {
                idusuariogenerado = 0;
                Mensaje=ex.Message;
            }
            return idusuariogenerado;
        }

        public bool Actualizar(Usuario obje, out string Mensaje)
        {

           bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexon = new SqlConnection(Conexion_Cp.cadena))
                {
                    /*

                     @IdUsuario int,
                    @Nomusuario varchar (50), 
                    @Contrasenia varchar(50),
                    @Respuesta bit output,	
                    @Mensaje varchar (500) output
                    )
                     */

                    SqlCommand cmd = new SqlCommand("SP_ACTUALIZARUSUARIO", oconexon);
                    cmd.Parameters.AddWithValue("IdUsuario", obje.idUsuaro);
                    cmd.Parameters.AddWithValue("Nomusuario", obje.nombre);
                    cmd.Parameters.AddWithValue("Contrasenia", obje.contraseña);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexon.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mesaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                  respuesta = false; 
          
                Mensaje = ex.Message;
            }
            return respuesta;
        }
        public bool Eliminar(Usuario obje, out string Mensaje)
        {

            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexon = new SqlConnection(Conexion_Cp.cadena))
                {
                    /*

                     @IdUsuario int,
                    @Nomusuario varchar (50), 
                    @Contrasenia varchar(50),
                    @Respuesta bit output,	
                    @Mensaje varchar (500) output
                    )
                     */

                    SqlCommand cmd = new SqlCommand("SP_EliminarUSUARIO", oconexon);
                    cmd.Parameters.AddWithValue("Nomusuario", obje.nombre);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexon.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mesaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;

                Mensaje = ex.Message;
            }
            return respuesta;
        }

    }
}
