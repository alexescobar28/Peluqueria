using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;
using Capa_Entidad;
namespace Capa_Negocios
{
    public class ClaseNegocios
    {
        ClaseDatos objd = new ClaseDatos();

        public DataTable N_listar_productos()
        {
            return objd.D_listar_productos();
        }
        public DataTable N_listar_usuarios()
        {
            return objd.D_listar_usuarios();
        }
        public DataTable N_listar_parametros()
        {
            return objd.D_listar_parametros();
        }

        public DataTable N_buscar_productos(ClaseEntidad obje)
        {
            return objd.D_buscar_productos(obje);
        }

        public DataTable N_buscar_usuarios(Usuario obje)
        {
            return objd.D_buscar_usuarios(obje);
        }

        public String N_mantenimiento_producto(ClaseEntidad obje)
        {
            return objd.D_mantenimiento_productos(obje);
        }

        public String N_mantenimiento_usuarios(Usuario obje)
        {
            return objd.D_mantenimiento_usuarios(obje);
        }
        public String N_mantenimiento_parametros(Parametros obje)
        {
            return objd.D_mantenimiento_parametros(obje);
        }

    }
}
