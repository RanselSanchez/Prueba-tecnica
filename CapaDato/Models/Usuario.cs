
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDato.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string apellido { get; set; }
        public string Cedula { get; set; }
        public string Usuario_nombre { get; set; }
        public string Contrasena { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }

        [DefaultValue("DEFAULT_USER")]
        public string Usuario_transaccion { get; set; }

        [DefaultValue(typeof(DateTime), "CURRENT_TIMESTAMP")]
        public DateTime Fecha_Transaccionn { get; set; }

        
        public int RoleId { get; set; }
        [JsonIgnore]
        public virtual Role Role { get; set; }

        public virtual List<Proyectos> proyectos { get; set; }



    }
}
