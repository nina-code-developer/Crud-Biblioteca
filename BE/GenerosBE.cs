using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GenerosBE
    {
        public int IdGenero { get; set; }
        public string Descripcion { get; set; }

        public GenerosBE() { }

        public GenerosBE(int idGenero, string descripcion)
        {
            IdGenero = idGenero;
            Descripcion = descripcion;
        }
    }

    


}
