using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Productos
    {
        public int IdProductos { get; set; }
        public string Nombre { get; set; }
        public ML.Tipo Tipo { get; set; }
        public decimal? Precio { get; set; }
    }
}
