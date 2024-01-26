using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDato.ViewModel
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string apellido { get; set; }
        public string Cedula { get; set; }
        public string Usuario_nombre { get; set; }
        public string Contrasena { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Usuario_transaccion { get; set; }
        public DateTime Fecha_Transaccionn { get; set; }


        public int RoleId { get; set; }
    }
}