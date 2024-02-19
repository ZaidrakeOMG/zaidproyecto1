using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zaidproyecto1.Models
{
    [Table("JefeEmpresa")]
    public class jefe
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public string TrabajoR { get; set; }
    }
}
