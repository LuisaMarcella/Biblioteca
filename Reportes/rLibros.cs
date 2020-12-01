using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Reportes
{
    public class rLibros
    {
        public int id { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int idAutor { get; set; }
        public int idGenero { get; set; }
        public int idEditorial { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public rLibros()
        {

        }

        public rLibros(rLibros Add)
        {
            id = Add.id;
            ISBN = Add.ISBN;
            Titulo = Add.Titulo;
            idAutor = Add.idAutor;
            idGenero = Add.idGenero;
            idEditorial = Add.idEditorial;
            FechaPublicacion = Add.FechaPublicacion;
        }
    }
}
