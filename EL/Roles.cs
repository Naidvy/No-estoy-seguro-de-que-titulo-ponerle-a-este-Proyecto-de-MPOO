using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Roles")]
    public class Roles
    {
        [Key]
        public short IdRol { get; set; }
        [MaxLength(50)]
        [Required]
        public string Rol { get; set; }
        [Required]
        public bool Activo { get; set; }
        [Required]
        public int IdUsuarioRegisra { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioActualiza { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public Roles()
        {
            Rol = string.Empty;
        }
    }
}
