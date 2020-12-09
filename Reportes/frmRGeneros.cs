using Biblioteca.Clases;
using Microsoft.Reporting.WinForms;
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

namespace Biblioteca.Reportes
{
    public partial class frmRGeneros : Form
    {
        static Conexion co = new Conexion();
        SqlConnection con = new SqlConnection(co.conexion());
        public frmRGeneros()
        {
            InitializeComponent();
        }

        private void frmRGeneros_Load(object sender, EventArgs e)
        {
            rep();
        }
        void rep()
        {
            string sql = "select * from Generos";
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            dataAdapter.Fill(dt);
            con.Close();
            this.rvGeneros.LocalReport.DataSources.Clear();
            this.rvGeneros.LocalReport.ReportEmbeddedResource = "Biblioteca.Reportes.repGeneros.rdlc";
            ReportDataSource reporte = new ReportDataSource("dsRGeneros", dt);
            this.rvGeneros.LocalReport.DataSources.Add(reporte);
            this.rvGeneros.RefreshReport();
        }
    }
}
