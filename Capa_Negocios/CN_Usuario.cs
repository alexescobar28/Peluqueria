using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class CN_Usuario
    {
        private Cd_Usuarios objcd_usuario = new Cd_Usuarios();
        public List<Usuario> listar()
        {
            return objcd_usuario.listar();

        }
        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje=string.Empty;
            if (obj.nombre == " ")
            {
                Mensaje += "Usuario no válido \n";
            }
            if (obj.contraseña ==" ")
            {
                Mensaje += "Contraseña no válida \n ";
            }
            if(Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                Mensaje += "Usuario registrado exitosamente";
                return objcd_usuario.Registrar(obj, out Mensaje);
            }
           

        }
        public bool Actualizar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.nombre == " ")
            {
                Mensaje += "Usuario no válido \n";
            }
            if (obj.contraseña == " ")
            {
                Mensaje += "Contraseña no válida \n ";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                Mensaje += "Credenciales actualizadas correctamente";
                return objcd_usuario.Actualizar(obj, out Mensaje);
            }
           

        }
        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objcd_usuario.Eliminar(obj, out Mensaje);

        }
    }

}
