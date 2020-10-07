using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class Conexion
    {
        public string conexion()
        {
            return @"Data Source = localhost\SQLExpress; Initial Catalog = BibliotecaSQL; User ID = marcella; Password = 1234;";
        }
    }
}
