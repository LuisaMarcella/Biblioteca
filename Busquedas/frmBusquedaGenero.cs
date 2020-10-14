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

namespace Biblioteca.Busquedas
{
    public partial class frmBusquedaGenero : Form
    {
        Conexion co = new Conexion();
        public frmBusquedaGenero()
        {
            InitializeComponent();
            this.generosTableAdapter.Connection.ConnectionString = co.conexion();
        }
        public frmBusquedaGenero(string sConexion)
        {
            InitializeComponent();
            this.generosTableAdapter.Connection.ConnectionString = sConexion;
        }

        private void frmBusquedaGenero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsGeneros.Generos' Puede moverla o quitarla según sea necesario.
            rellenar();
        }
        void rellenar()
        {
            this.generosTableAdapter.Fill(this.dsGeneros.Generos, txtFiltro.Text);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            rellenar();
        }
    }
}
