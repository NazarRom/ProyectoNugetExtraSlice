using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProyectoExtraSlice.Models
{
    public class UsuarioAux
    {
        public string Nombre_cliente { get; set; }
       
        public string Direccion { get; set; }
       
        public string Telefono { get; set; }
       
        public string Email { get; set; }
        
        public string Password { get; set; }
    }
}
