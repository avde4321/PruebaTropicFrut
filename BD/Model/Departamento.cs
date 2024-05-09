using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Model
{
    public class Departamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? codDepto {  get; set; }
        public string? nombreDpto {  get; set; }
        public string? ciudad {  get; set; }
        public string? codDirector {  get; set; }

        public virtual ICollection<Empleado>? Empleados { get; set; }
    }
}
