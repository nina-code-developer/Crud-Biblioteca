using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class EditorialBE
    {
        public int IdEditorial { get; set; }
        public string Descripcion { get; set; }

        public EditorialBE() { }

        public EditorialBE(int idEditorial, string descripcion)
        {
            IdEditorial = idEditorial;
            Descripcion = descripcion;
        }
    }
}
