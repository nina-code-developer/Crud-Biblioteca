using System;
using System.Collections.Generic;

using BE;
using DB;
using System.Data.SqlClient;

namespace BL {
    public class AutorBL {
        public void Insert(AutorBE autorBE) {

            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer())) {
                sqlConn.Open();

                //Se define el objeto comando SQL
                SqlCommand sqlCmd = sqlConn.CreateCommand();

                //Query SQL
                sqlCmd.CommandText = "insert into " + //importante dejar espacio
                    "Autores(Apellido,Nombre,FechaNacimiento,Nacionalidad) " + //dejar espacio
                    "values(@Apellido,@Nombre,@FechaNacimiento,@Nacionalidad)";


                //Cargar los parámetros
                sqlCmd.Parameters.AddWithValue("@Apellido", autorBE.Apellido);
                sqlCmd.Parameters.AddWithValue("@Nombre", autorBE.Nombre);
                sqlCmd.Parameters.AddWithValue("@FechaNacimiento", autorBE.FechaNacimiento);
                sqlCmd.Parameters.AddWithValue("@Nacionalidad", autorBE.Nacionalidad);

                //Ejecutar Query SQL
                //Resultado filas afectadas
                int rows = sqlCmd.ExecuteNonQuery();

                if (rows != 1)
                    throw new Exception("Error INSERT Autor!");


                sqlConn.Close();
            }
        }


        //Se utiliza para modificar los registros existentes en una tabla
        public void Update(AutorBE autorBE) 
        {
            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer())) {
                sqlConn.Open();

                //Se define el objeto comando SQL
                SqlCommand sqlCmd = sqlConn.CreateCommand();

                //Query SQL
                sqlCmd.CommandText = "update Autores set " +
                                     "Apellido=@Apellido, Nombre=@Nombre, " +
                                     "FechaNacimiento=@FechaNacimiento, Nacionalidad=@Nacionalidad " +
                                     "where ID=@ID";

                //Cargar los parámetros
                sqlCmd.Parameters.AddWithValue("@Apellido", autorBE.Apellido);
                sqlCmd.Parameters.AddWithValue("@Nombre", autorBE.Nombre);
                sqlCmd.Parameters.AddWithValue("@FechaNacimiento", autorBE.FechaNacimiento);
                sqlCmd.Parameters.AddWithValue("@Nacionalidad", autorBE.Nacionalidad);
                sqlCmd.Parameters.AddWithValue("@ID", autorBE.ID);

                //Ejecutar Query SQL
                //Resultado filas afectadas
                int rows = sqlCmd.ExecuteNonQuery();

                if (rows != 1)
                    throw new Exception("¡Error Update Autor!"); //supuesto error

                sqlConn.Close();
            }
        }


        //Metodo de borrar
        public void Delete(int ID)
        {
            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer()))
            {
                sqlConn.Open();

                //Se define el objeto comando SQL
                SqlCommand sqlCmd = sqlConn.CreateCommand();

                //Query SQL
                sqlCmd.CommandText = "delete from Autores where ID=@ID";

                //Cargar los parámetros
                sqlCmd.Parameters.AddWithValue("@ID",ID);

                //Ejecutar Query SQL
                //Resultado filas afectadas
                int rows = sqlCmd.ExecuteNonQuery();

                if (rows != 1)
                    throw new Exception("¡Error Delete Autor!"); //supuesto error

                sqlConn.Close();
            }
        }

        //Boton de buscar por ID
        public AutorBE FindById(int ID) {
            AutorBE autorBE = null;

            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer())) {
                sqlConn.Open();

                //Se define el objeto comando SQL
                SqlCommand sqlCmd = sqlConn.CreateCommand();

                //Query SQL
                sqlCmd.Parameters.AddWithValue("@ID", ID);
                sqlCmd.CommandText = "select * from Autores where ID=@ID";

                //Ejecutar el Query SQL -- Datos
                SqlDataReader sqlDR = sqlCmd.ExecuteReader();

                //Recorrer fila si existe
                if (sqlDR.Read()) {
                    autorBE = new AutorBE();

                    autorBE.ID = sqlDR.GetInt32(0); //EN SQL INICIA DESDE 0
                    autorBE.Apellido = sqlDR.GetString(1);
                    autorBE.Nombre = sqlDR.GetString(2); //Almacena 
                    autorBE.FechaNacimiento = sqlDR.GetDateTime(3);
                    autorBE.Nacionalidad = sqlDR.GetInt32(4);
                }
                sqlConn.Close();
            }
            return autorBE;
        }

        //Comando Select //Para recorrer la base de datos como una lista
        public List<AutorBE> FindAll() {
            List<AutorBE> list = new List<AutorBE>(); //Listar los datos ingresados

            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer())) {
                sqlConn.Open();

                //Se define el objeto comando SQL
                SqlCommand sqlCmd = sqlConn.CreateCommand();

                //Query SQL
                sqlCmd.CommandText = "select * from Autores order by ID";

                //Ejecutar el Query SQL -- Datos
                SqlDataReader sqlDR = sqlCmd.ExecuteReader();

                //Recorremos fila por fila
                while (sqlDR.Read()) {
                    AutorBE autorBE = new AutorBE();

                    autorBE.ID = sqlDR.GetInt32(0); //EN SQL INICIA DESDE 0
                    autorBE.Apellido = sqlDR.GetString(1);
                    autorBE.Nombre = sqlDR.GetString(2); //Almacena 
                    autorBE.FechaNacimiento = sqlDR.GetDateTime(3);
                    autorBE.Nacionalidad = sqlDR.GetInt32(4);

                    list.Add(autorBE);
                }

                sqlConn.Close();
            }

            return list;
        }
    }
}
