using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class LibrosBE
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int Edicion { get; set; }
        public int IdGenero { get; set; }
        public int IdEditorial { get; set; }

        public LibrosBE() { }

        public LibrosBE(string iSBN, string titulo, int edicion, 
            int idGenero, int idEditorial)
        {
            ISBN = iSBN;
            Titulo = titulo;
            Edicion = edicion;
            IdGenero = idGenero;
            IdEditorial = idEditorial;
        }



    }
}
