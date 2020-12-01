using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Reportes
{
    public partial class frmRLibros : Form
    {
        public frmRLibros()
        {
            InitializeComponent();
        }

        private void frmRLibros_Load(object sender, EventArgs e)
        {

            this.rvRepLibros.RefreshReport();
        }
    }
}
