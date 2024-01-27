using System;
using System.Windows.Forms;

using BE;

using BL;

using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI {
    public partial class AutorForm : Form {
        //Llamando a los servicios del AutorBL (Insert,FindAll)
        private readonly AutorBL autorBL = new AutorBL();
        private bool isEdit = false;
        private int inputID = 0;

        //Llamado a los servicios del PaisBL
        //private PaisBL paisBL = new PaisBL();

        //Llamando a los servicios del AutorBL(Insert)
        //private AutorBL autorBL = new AutorBL();

        public AutorForm() {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            DateTime fNacimiento = Convert.ToDateTime(dateNacimiento.Value);
            int nacionalidad = Convert.ToInt32(txtNacionalidad.Text);

            if (isEdit == true) {
                AutorBE autorBE =
                    new AutorBE(inputID, apellido, nombre, fNacimiento, nacionalidad);

                autorBL.Update(autorBE);

                //Mensaje
                MessageBox.Show("¡Autor Actualizado exitosamente!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                //Instancia un nuevo autor
                AutorBE autorBE = new AutorBE(apellido, nombre, fNacimiento, nacionalidad);

                //Guardar en la base de datos
                autorBL.Insert(autorBE);

                //Mensaje
                MessageBox.Show("¡Nuevo autor registrado!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Refrescar tabla
            LimpiarDatos();

            isEdit = false;
            inputID = 0;
            btnGuardar.Text = "Guardar";
            btnEliminar.Enabled = false;
        }

        //Metodo de arranque 
        private void AutorForm_Load(object sender, EventArgs e) {
            //Para procesar toda la tabla de la base de datos
            LimpiarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            try {
                inputID = Convert.ToInt32(Interaction.InputBox("Ingrese ID Autor:"));
                AutorBE autorBE = autorBL.FindById(inputID);

                if (autorBE == null) {
                    MessageBox.Show("¡Error ID no existe!", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    txtApellido.Text = autorBE.Apellido;
                    txtNombre.Text = autorBE.Nombre;
                    dateNacimiento.Value = autorBE.FechaNacimiento;

                    txtNacionalidad.Text = autorBE.Nacionalidad.ToString();

                    btnGuardar.Text = "Actualizar"; //SI NO FUNCIONA RETORNO A MINUSCULA
                    isEdit = true;
                    btnEliminar.Enabled = true;
                }
            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message, "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);  //"Error de formato" Una posible 
            }                                                                 //Advertencia
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton Eliminar

        private void LimpiarDatos() {
            txtApellido.Text = null;
            txtNombre.Text = null;
            dateNacimiento.Value = DateTime.Today;
            txtNacionalidad.Text = null;
            txtApellido.Focus();

            gridAutores.DataSource = autorBL.FindAll();

            inputID = 0;
            //btnEliminar.Enabled = false;

            //El formulario cambiará su modo de "búsqueda" a "actualización" y
            //el botón "Guardar" se utilizará para actualizar los detalles del autor.
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro de eliminar la fila?",
                "Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                autorBL.Delete(inputID);

                MessageBox.Show("¡Autor Eliminado Exitosamente!", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar tabla
                LimpiarDatos();

                isEdit = false;
                inputID = 0;
                btnGuardar.Text = "Guardar";
                btnEliminar.Enabled = false;

            }

            
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = null;
            txtNombre.Text = null;
            dateNacimiento.Value = DateTime.Today;
            txtNacionalidad.Text = null;
            txtApellido.Focus();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = null;
            txtNombre.Text = null;
            dateNacimiento.Value = DateTime.Today;
            txtNacionalidad.Text = null;
            txtApellido.Focus();

            LimpiarDatos();

            isEdit = false;
            inputID = 0;
            btnGuardar.Text = "Guardar";
            btnEliminar.Enabled = false;
        }
    }
}
