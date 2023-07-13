using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacion.models
{
    internal class Producto
    {
        public Int32? Id { get; set; }
        public string? descripcion { get; set; }
        public double? precio { get; set; }

     

        public override string ToString()
        {
            return descripcion;
        }


    }
}
