using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Model
{
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? nDIEmp { get; set; }
        public string? nomEmp { get; set; }
        public string? seEmp { get; set; }
        public DateTime fecNac { get; set; }
        public DateTime fecIncorporacion { get; set; }
        public float salEmp { get; set; }
        public float comisionE { get; set; }
        public string? cargoE { get; set; }
        public string? jefeId { get; set; }
        public string? codeDepto { get; set; }

        [ForeignKey("codeDepto")]
        public virtual Departamento? departamentos { get; set; }

    }
}
