using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CentroMedico.BL.Models
{
    [Table("Ciudades", Schema = "dbo")]
    public class Ciudad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CiudadID { get; set; }
        public string NombreCiudad { get; set; }
        [ForeignKey("Departamentos")]
        public int DepartamentoID { get; set; }

        public Departamentos Departamentos { get; set; }
    }
}
