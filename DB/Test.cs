using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importamos la conexion
using System.Data.SqlClient; 

//Clase para verificar si verdaderamente funciona 

namespace DB
{
    public class Test
    {
        //Metodo Ejecutable
        public static void Main(string[] args)
        {
            using(SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
            { 
                //Abrir conexion
                sqlConn.Open();

                //Mensaje de Prueba
                Console.WriteLine("¡Conexion Exitosa!");

                //Cerrar Conexion
                sqlConn.Close();
            }

            Console.ReadLine();
        }
    }
}
