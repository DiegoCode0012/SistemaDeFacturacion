using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacion.models
{
    internal class Factura
    {
        public Int32? Id { get; set; }
        public List<Item>? items { get; set; }

        public Cliente? Cliente { get; set; }
        public SqlDateTime? fecha { get; set; }
        public void agregar(Item item)
        {
            items.Add(item);
        }
        public double calcularTotal()
        {
            double x = 0;
            for (int i = 0; i < items.Count; i++)
            {
                x += items[i].calcularImporte();
            }
            return x;
        }
    }
}
