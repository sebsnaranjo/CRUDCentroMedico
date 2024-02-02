using AutoMapper;
using CentroMedico.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedico.BL.DTOs
{
    public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Paciente, PacienteDTO>(); // GET
                cfg.CreateMap<PacienteDTO, Paciente>(); // POST-PUT
            });
        }
    }
}
