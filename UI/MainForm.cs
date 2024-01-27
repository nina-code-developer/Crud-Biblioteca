using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuAutor_Click(object sender, EventArgs e)
        {
            AutorForm form = new AutorForm();
            form.Show();
            this.Hide();
        }
        

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibroForm form = new LibroForm();
            form.Show();
            this.Hide();
        }

    }

}
