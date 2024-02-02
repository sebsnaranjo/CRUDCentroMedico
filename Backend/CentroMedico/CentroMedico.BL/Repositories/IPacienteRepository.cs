using CentroMedico.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroMedico.BL.Repositories;

namespace CentroMedico.BL.Repositories
{
    public interface IPacienteRepository : IGenericRepository<Paciente>
    {
    }
}
