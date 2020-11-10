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
    public partial class frmLibros : Form
    {
        public frmLibros()
        {
            InitializeComponent();
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsvEditoriales.Editoriales' Puede moverla o quitarla según sea necesario.
            this.editorialesTableAdapter.Fill(this.dsvEditoriales.Editoriales);
            // TODO: esta línea de código carga datos en la tabla 'dsvAutores.vAutores' Puede moverla o quitarla según sea necesario.
            this.vAutoresTableAdapter.Fill(this.dsvAutores.vAutores);

        }
    }
}
