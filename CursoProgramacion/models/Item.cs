using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacion.models
{
    internal class Item
    {
        public Producto? producto { get; set; }
        public double? cantidad { get; set; }

        public Factura? factura { get; set; }
        public double calcularImporte(){

            return (double)producto.precio*(double)cantidad;
        }
    }   
}
