using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CentroMedico.BL.DTOs
{
    public class PacienteDTO
    {
        public int PacienteID { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string TipoDocumento { get; set; }
        [Required]
        public string NumeroDocumento { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public string CiudadResidencia { get; set; }
        [Required]
        public string DepartamentoResidencia { get; set; }
        /*[Required]
        public int DepartamentoID { get; set; }*/
    }
}
