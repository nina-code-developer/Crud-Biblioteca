using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class AutorBE
    {
        public int ID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get;  set; }
        public DateTime FechaNacimiento { get; set; }
        public int Nacionalidad { get; set; }

        public AutorBE() { }

        public AutorBE(int iD, string apellido, string nombre, 
            DateTime fNacimiento, int nacionalidad)
        {
            ID = iD;
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimiento = fNacimiento;
            Nacionalidad = nacionalidad;
        }

        public AutorBE(string apellido, string nombre,
            DateTime fNacimiento, int nacionalidad)
        {
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimiento = fNacimiento;
            Nacionalidad = nacionalidad;
        }

    }
}
