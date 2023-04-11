using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNugetExtraSlice
{
    public class Restaurante
    {
        public int IdRestaurante { get; set; }
        public string Nombre_restaurante { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Id_categoria { get; set; }
        public string Imagen { get; set; }
    }
}
