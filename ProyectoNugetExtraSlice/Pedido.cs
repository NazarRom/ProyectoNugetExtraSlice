using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNugetExtraSlice
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime Fecha_hora { get; set; }
        public int IdCliente { get; set; }
    }
}
