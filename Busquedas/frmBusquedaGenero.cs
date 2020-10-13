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
    public partial class frmBusquedaGenero : Form
    {
        public frmBusquedaGenero()
        {
            InitializeComponent();
        }

        private void frmBusquedaGenero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsGeneros.Generos' Puede moverla o quitarla según sea necesario.
            this.generosTableAdapter.Fill(this.dsGeneros.Generos);

        }
    }
}
