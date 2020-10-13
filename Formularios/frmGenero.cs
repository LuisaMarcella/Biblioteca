using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Clases;

namespace Biblioteca.Formularios
{
    public partial class frmGenero : Form
    {
        public frmGenero()
        {
            InitializeComponent();
        }

        private void frmGenero_Load(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtID.Text = "0";
        }
        void limpiar()
        {
            txtID.Text = "0";
            txtNombre.Clear();
        }
        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Clases.Genero x = new Clases.Genero();
            x.id = int.Parse(txtID.Text);
            if(txtNombre.Text == "")
            {
                MessageBox.Show("EL CAMPO NOMBRE NO PUEDE IR VACIO.");
            }
            else
            {
                x.Nombre = txtNombre.Text;
                MessageBox.Show(x.guardar());
                limpiar();
            }
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
