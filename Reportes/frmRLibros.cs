﻿using Biblioteca.Clases;
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
    public partial class frmRLibros : Form
    {
        static Conexion co = new Conexion();
        SqlConnection con = new SqlConnection(co.conexion());
        public frmRLibros()
        {
            InitializeComponent();
        }

        private void frmRLibros_Load(object sender, EventArgs e)
        {
            rep();
        }
        void rep()
        {

            string sql = "select * from vLibros";
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            dataAdapter.Fill(dt);
            con.Close();
            this.rvRepLibros.LocalReport.DataSources.Clear();
            this.rvRepLibros.LocalReport.ReportEmbeddedResource = "Biblioteca.Reportes.repLibros.rdlc";
            ReportDataSource reporte = new ReportDataSource("dsrLibros", dt);
            this.rvRepLibros.LocalReport.DataSources.Add(reporte);
            this.rvRepLibros.RefreshReport();
        }
    }
}
