using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidad; 
namespace Capa_Datos
{
    public class Conexion_Cp
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["sql"].ToString();

    }
}
