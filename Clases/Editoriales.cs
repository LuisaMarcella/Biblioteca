using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class Editoriales
    {
        static Conexion co = new Conexion();
        SqlConnection con = new SqlConnection(co.conexion());
        SqlCommand comando = new SqlCommand();
        public int id;
        public string Nombre;
        public bool encontro = false;
        public Editoriales()
        {
            comando.Connection = con;
        }
        public void buscar()
        {
            Busquedas.frmBusquedaEditoriales x = new Busquedas.frmBusquedaEditoriales();
            x.ShowDialog();
            if (x.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                id = int.Parse(x.dgEditoriales.SelectedRows[0].Cells["id"].Value.ToString());
                Nombre = x.dgEditoriales.SelectedRows[0].Cells["Nombre"].Value.ToString();
                encontro = true;
            }
            else
                encontro = false;
        }
    }
}
