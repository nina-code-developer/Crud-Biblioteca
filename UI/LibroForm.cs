using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BE;
using BL;

namespace UI
{
    public partial class LibroForm : Form
    {
        //Llamando a los servicios del AutorBL
        private LibrosBL librosBL = new LibrosBL();

        public LibroForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string iSBN = txtIsbn.Text;
            string titulo = txtTitulo.Text;
            int edicion = Convert.ToInt32(txtEdicion.Text);
            int idGenero = Convert.ToInt32(txtGenero.Text);
            int idEditorial = Convert.ToInt32(txtEditorial.Text);

            //Instancia de un nuevo Libro
            LibrosBE librosBE = new LibrosBE(iSBN,titulo,edicion,idGenero,idEditorial);

            //Guardar en la base de datos
            librosBL.Insert(librosBE);

            // Mostrar el mensaje de error en un MessageBox
            MessageBox.Show("Nuevo libro ingresado","Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void LibroForm_Load(object sender, EventArgs e)
        {
            gridLibro.DataSource = librosBL.FindAll();
        }

        private void btnActualizarLibro_Click(object sender, EventArgs e)
        {
            gridLibro.DataSource = librosBL.FindAll();
        }
    }
}
