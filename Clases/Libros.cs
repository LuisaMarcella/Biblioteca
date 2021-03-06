﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class Libros
    {
        static Conexion co = new Conexion();
        SqlConnection con = new SqlConnection(co.conexion());
        SqlCommand comando = new SqlCommand();

        public int id;
        public string ISBN;
        public string Titulo;
        public int idAutor;
        public int idGenero;
        public int idEditorial;
        public DateTime FechaPublicacion;
        public bool encontro = false;

        public Libros()
        {
            comando.Connection = con;
        }

        public string guardar()
        {
            string mensaje = "";
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "spLibros";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@op", 2);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@ISBN", ISBN);
            comando.Parameters.AddWithValue("@Titulo", Titulo);
            comando.Parameters.AddWithValue("@idAutor", idAutor);
            comando.Parameters.AddWithValue("@idGenero", idGenero);
            comando.Parameters.AddWithValue("@idEditorial", idEditorial);
            comando.Parameters.AddWithValue("@FechaPublicacion", FechaPublicacion);

            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
            mensaje = "Listo";
            return mensaje;
        }
        public void buscar()
        {
            Busquedas.frmBusquedaLibros x = new Busquedas.frmBusquedaLibros(con.ConnectionString);
            x.ShowDialog();
            if (x.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                id = x.dsLibros.vLibros[x.vLibrosBindingSource.Position].id;
                ISBN = x.dsLibros.vLibros[x.vLibrosBindingSource.Position].ISBN;
                Titulo = x.dsLibros.vLibros[x.vLibrosBindingSource.Position].Titulo;
                idAutor = x.dsLibros.vLibros[x.vLibrosBindingSource.Position].idAutor;
                idGenero = x.dsLibros.vLibros[x.vLibrosBindingSource.Position].idGenero;
                idEditorial = x.dsLibros.vLibros[x.vLibrosBindingSource.Position].idEditorial;
                FechaPublicacion = x.dsLibros.vLibros[x.vLibrosBindingSource.Position].FechaPublicacion;
                encontro = true;
            }
            else
                encontro = false;
        }
        public string eliminar()
        {
            string mensaje = "";
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "spLibros";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@op", 3);
            comando.Parameters.AddWithValue("@id", id);

            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
            mensaje = "Campo eliminado.";

            return mensaje;
        }
    }
}
