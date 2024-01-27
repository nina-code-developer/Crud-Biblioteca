using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Proveedor exclusivo para conexion a SQLServer
using System.Data.SqlClient;


namespace DB
{
    public class Conexion
    {
        public static string SQLServer()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            //Nombre del Servidor
            builder.DataSource = "NinaCode\\SQLEXPRESS";

            //Nombre de la Base de datos
            builder.InitialCatalog = "Biblioteca";

            //Conexion sin user y password
            builder.IntegratedSecurity = true;


            return builder.ToString();


        }
    }
}
