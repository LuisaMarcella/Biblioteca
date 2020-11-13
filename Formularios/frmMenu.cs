using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Formularios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibros x = new frmLibros();
            x.Show();
        }

        private void tsGeneros_Click(object sender, EventArgs e)
        {
            frmGenero x = new frmGenero();
            x.Show();
        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditorial x = new frmEditorial();
            x.Show();
        }
    }
}
