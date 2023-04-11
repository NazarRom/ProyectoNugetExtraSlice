using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNugetExtraSlice
{
    public class Usuario
    {
        public int IdUser { get; set; }
        public string Nombre_cliente { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public byte[] PasswordCifrado { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}
