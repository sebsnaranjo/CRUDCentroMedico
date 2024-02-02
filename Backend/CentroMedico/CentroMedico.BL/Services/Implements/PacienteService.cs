using CentroMedico.BL.Models;
using CentroMedico.BL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedico.BL.Services.Implements
{
    public class PacienteService : GenericService<Paciente>, IPacienteService 
    {
        public PacienteService(IPacienteRepository pacienteRepository): base(pacienteRepository)
        {

        }
    }
}
