using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDato.ViewModel
{
    public class RoleViewModel
    {
        public int RoleId { get; set; }
        public string nombre { get; set; }
        public string Usuario_transaccion { get; set; }
        public DateTime Fecha_Transaccionn { get; set; }
    }
}