using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNugetExtraSlice
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre_producto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int IdRestaurante { get; set; }
    }
}
