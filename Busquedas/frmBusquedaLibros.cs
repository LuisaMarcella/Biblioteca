using Biblioteca.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Busquedas
{
    public partial class frmBusquedaLibros : Form
    {
        Conexion co = new Conexion();
        public frmBusquedaLibros()
        {
            InitializeComponent();
            this.vLibrosTableAdapter.Connection.ConnectionString = co.conexion();
        }
        public frmBusquedaLibros(string sConexion)
        {
            InitializeComponent();
            this.vLibrosTableAdapter.Connection.ConnectionString = sConexion;
        }

        private void frmBusquedaLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsLibros.vLibros' Puede moverla o quitarla según sea necesario.
            rellenar();
        }
        void rellenar()
        {
            this.vLibrosTableAdapter.Fill(this.dsLibros.vLibros, txtFiltro.Text);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            rellenar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
