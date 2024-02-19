using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zaidproyecto1.Models
{
    [Table("Empleado")]
    public class empleado
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string nombreE { get; set; }

        public string apellidoE { get; set; }

        public int NumeroE { get; set; }

        public string TrabajoE { get; set; }

        public virtual jefe Jefe { get; set; }

    }
}
