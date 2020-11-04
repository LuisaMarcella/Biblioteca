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
using System.Data.SqlClient;

namespace Biblioteca.Formularios
{
    public partial class frmGenero : Form
    {
        static Conexion co = new Conexion();
        SqlConnection con = new SqlConnection(co.conexion());
        SqlDataReader lector;
        public frmGenero()
        {
            InitializeComponent();
        }

        private void frmGenero_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            cargarconsecutivo();
        }
        void limpiar()
        {
            cargarconsecutivo();
            txtNombre.Clear();
        }
        void cargarconsecutivo()
        {
            SqlCommand comando = new SqlCommand("select isnull(max(id),0)+1 as maxid from Generos", con);
            con.Open();
            lector = comando.ExecuteReader();
            if(lector.Read())
            {
                txtID.Text = lector["maxid"].ToString();
            }
            con.Close();
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

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            Clases.Genero x = new Genero();
            x.buscar();
            if(x.encontro == true)
            {
                txtID.Text = x.id.ToString();
                txtNombre.Text = x.Nombre;
            }
        }
    }
}
