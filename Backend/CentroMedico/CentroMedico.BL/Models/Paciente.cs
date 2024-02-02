using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CentroMedico.BL.Models
{
    [Table("Pacientes", Schema = "dbo")]
    public class Paciente
    {
        [Key]
        public int PacienteID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TipoDocumento { get; set; } 
        public string NumeroDocumento { get; set; } 
        public DateTime FechaNacimiento { get; set; }
        public string CiudadResidencia { get; set; }
        public string DepartamentoResidencia { get; set; }
        /*[ForeignKey("Departamentos")]
        public int DepartamentoID { get; set; }

        public Departamentos Departamentos { get; set; }*/
    }
}
