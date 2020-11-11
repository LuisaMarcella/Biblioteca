using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Clases;

namespace Biblioteca.Formularios
{
    public partial class frmLibros : Form
    {
        static Conexion x = new Conexion();
        string sConexion = x.conexion();
        public frmLibros()
        {
            InitializeComponent();
            editorialesTableAdapter.Connection.ConnectionString = sConexion;
            vAutoresTableAdapter.Connection.ConnectionString = sConexion;
            llenargeneros();
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsvEditoriales.Editoriales' Puede moverla o quitarla según sea necesario.
            this.editorialesTableAdapter.Fill(this.dsvEditoriales.Editoriales);
            // TODO: esta línea de código carga datos en la tabla 'dsvAutores.vAutores' Puede moverla o quitarla según sea necesario.
            this.vAutoresTableAdapter.Fill(this.dsvAutores.vAutores);
        }
        void llenargeneros()
        {
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Generos", sConexion);
            da.Fill(tb);
            cboGenero.DisplayMember = "Nombre";
            cboGenero.ValueMember = "id";
            cboGenero.DataSource = tb;
        }
    }
}
