using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.ViewModel
{
    public class ProyectoViewModel
    {
        public int Id { get; set; }
        public string Proyecto { get; set; }
        public string Descripcion { get; set; }
        public string Usuario_transaccion { get; set; }
        public DateTime Fecha_Transaccionn { get; set; }
        public int usuarioId { get; set; }
    }
}
