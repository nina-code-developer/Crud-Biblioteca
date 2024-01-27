using System;
using System.Collections.Generic;


using BE;
using DB;
using System.Data.SqlClient;

namespace BL {
    public class LibrosBL {
        public void Insert(LibrosBE librosBE) {
            using (SqlConnection sqlLibroConn = new SqlConnection(Conexion.SQLServer())) {
                sqlLibroConn.Open();

                //Se define el objeto comando SQL
                SqlCommand sqlLibro2 = sqlLibroConn.CreateCommand();

                //Query SQL
                sqlLibro2.CommandText = "insert into " + //dejamos el espacio
                    "Libros(ISBN, Titulo, Edicion, IdGenero, IdEditorial) " +
                    "values(@ISBN,@Titulo, @Edicion, @IdGenero, @IdEditorial)";

                //Cargar Parametros
                sqlLibro2.Parameters.AddWithValue("@ISBN", librosBE.ISBN);
                sqlLibro2.Parameters.AddWithValue("@Titulo", librosBE.Titulo);
                sqlLibro2.Parameters.AddWithValue("@Edicion", librosBE.Edicion);
                sqlLibro2.Parameters.AddWithValue("@IdGenero", librosBE.IdGenero);
                sqlLibro2.Parameters.AddWithValue("@IdEditorial", librosBE.IdEditorial);

                //Ejecutar Query
                int rows = sqlLibro2.ExecuteNonQuery();

                sqlLibroConn.Close();
            }
        }

        public List<LibrosBE> FindAll() {
            List<LibrosBE> list2 = new List<LibrosBE>(); //Listar los datos ingresados

            using (SqlConnection sqlConn = new SqlConnection(Conexion.SQLServer())) {
                sqlConn.Open();

                //Se define el objeto comando SQL
                SqlCommand sqlLibro2 = sqlConn.CreateCommand();

                //Query SQL
                sqlLibro2.CommandText = "select * from Libros order by ISBN";

                //Ejecutar el Query SQL -- Datos
                SqlDataReader sqlDR = sqlLibro2.ExecuteReader();

                //Recorremos fila por fila
                while (sqlDR.Read()) {
                    LibrosBE librosBE = new LibrosBE();

                    librosBE.ISBN = sqlDR.GetString(0); //EN SQL INICIA DESDE 0
                    librosBE.Titulo = sqlDR.GetString(1);
                    librosBE.Edicion = sqlDR.GetInt32(2);//Almacena 
                    librosBE.IdGenero = sqlDR.GetInt32(3);
                    librosBE.IdEditorial = sqlDR.GetInt32(4);

                    list2.Add(librosBE);
                }
                sqlConn.Close();
            }
            return list2;
        }
    }
}
