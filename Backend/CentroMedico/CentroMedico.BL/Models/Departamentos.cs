using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CentroMedico.BL.Models
{
    [Table("Departamentos", Schema = "dbo")]
    public class Departamentos
    {
        [Key]
        public int DepartamentoID { get; set; }
        public string NombreDepartamento { get; set; }

        public virtual ICollection<Ciudad> Ciudad { get; set; }
        /*public virtual ICollection<Paciente> Paciente { get; set; }*/
    }
}
