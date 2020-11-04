using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Clases
{
    public class Genero
    {
        static Conexion co = new Conexion();
        SqlConnection con = new SqlConnection(co.conexion());
        SqlCommand comando = new SqlCommand();

        public int id;
        public string Nombre;
        public bool encontro = false;

        public Genero()
        {
            comando.Connection = con;
        }
        public Genero(string sConexion)
        {
            con.ConnectionString = sConexion;
            comando.Connection = con;
        }

        public string guardar()
        {
            string mensaje = "";
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "spGeneros";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@op", 2);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@Nombre", Nombre);

            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
            mensaje = "Listo";
            return mensaje;
        }

        public void buscar()
        {
            Busquedas.frmBusquedaGenero x = new Busquedas.frmBusquedaGenero(con.ConnectionString);
            x.ShowDialog();
            if (x.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                id = x.dsGeneros.Generos[x.generosBindingSource.Position].id;
                Nombre = x.dsGeneros.Generos[x.generosBindingSource.Position].Nombre;
                encontro = true;
            }
            else
                encontro = false;
        }
    }
}
