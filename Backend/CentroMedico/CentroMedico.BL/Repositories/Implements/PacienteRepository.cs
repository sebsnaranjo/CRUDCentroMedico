using CentroMedico.BL.Data;
using CentroMedico.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroMedico.BL.Repositories.Implements;

namespace CentroMedico.BL.Repositories.Implements
{
    public class PacienteRepository : GenericRepository<Paciente>, IPacienteRepository
    {
        public PacienteRepository(CentroMedicoContext centroMedicoContext) : base(centroMedicoContext)
        {

        }
    }
}
