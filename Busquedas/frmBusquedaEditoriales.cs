using Biblioteca.Clases;
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

namespace Biblioteca.Busquedas
{
    public partial class frmBusquedaEditoriales : Form
    {
        Conexion co = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmBusquedaEditoriales()
        {
            InitializeComponent();
            con.ConnectionString = co.conexion();
        }

        private void frmBusquedaEditoriales_Load(object sender, EventArgs e)
        {
            cargardg();
        }
        void cargardg()
        {
            string sql = "SELECT id, Nombre FROM Editoriales where Nombre LIKE '%" + txtFiltro.Text + "%'";
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            dataAdapter.Fill(dt);
            dgEditoriales.DataSource = dt;
            con.Close();            
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            cargardg();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
