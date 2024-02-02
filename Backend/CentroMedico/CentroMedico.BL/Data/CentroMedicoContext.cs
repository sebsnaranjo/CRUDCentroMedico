using CentroMedico.BL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedico.BL.Data
{
    public class CentroMedicoContext : DbContext
    {
        private static CentroMedicoContext centroMedicoContext = null;
        public CentroMedicoContext() : base("CentroMedicoContext")
        {
                
        }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }

        public static CentroMedicoContext Create()
        {
            if(centroMedicoContext == null)
            {
                centroMedicoContext = new CentroMedicoContext();
            }

            return centroMedicoContext;
        }

    }
}
