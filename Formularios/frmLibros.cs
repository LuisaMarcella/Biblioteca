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
        SqlDataReader lector;
        static Conexion x = new Conexion();
        SqlConnection con = new SqlConnection(x.conexion());
        string sConexion = x.conexion();
        public frmLibros()
        {
            InitializeComponent();
            editorialesTableAdapter.Connection.ConnectionString = sConexion;
            vAutoresTableAdapter.Connection.ConnectionString = sConexion;
            llenargeneros();
            cargarconsecutivo();
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsvEditoriales.Editoriales' Puede moverla o quitarla según sea necesario.
            this.editorialesTableAdapter.Fill(this.dsvEditoriales.Editoriales);
            // TODO: esta línea de código carga datos en la tabla 'dsvAutores.vAutores' Puede moverla o quitarla según sea necesario.
            this.vAutoresTableAdapter.Fill(this.dsvAutores.vAutores);
        }
        void cargarconsecutivo()
        {
            SqlCommand comando = new SqlCommand("select isnull(max(id),0)+1 as maxid from Libros", con);
            con.Open();
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                txtID.Text = lector["maxid"].ToString();
            }
            con.Close();
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

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            Libros x = new Libros();
            x.id = int.Parse(txtID.Text);
            x.ISBN = txtISBN.Text;
            x.Titulo = txtTitulo.Text;
            x.idAutor = int.Parse(cboAutor.SelectedValue.ToString());
            x.idGenero = int.Parse(cboGenero.SelectedValue.ToString());
            x.idEditorial = int.Parse(cboEditorial.SelectedValue.ToString());
            x.FechaPublicacion = dtpFechaDePublicacion.Value;
            MessageBox.Show(x.guardar());
        }
    }
}
