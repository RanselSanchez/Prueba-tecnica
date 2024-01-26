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
    public class Proyectos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Proyecto { get; set; }
        public string Descripcion { get; set; }

        [DefaultValue("DEFAULT_USER")]
        public string Usuario_transaccion { get; set; }

        [DefaultValue(typeof(DateTime), "CURRENT_TIMESTAMP")]
        public DateTime Fecha_Transaccionn { get; set; }


        public int usuarioId { get; set; }
        [JsonIgnore]
        public virtual Usuario user { get; set; }

    }
}
