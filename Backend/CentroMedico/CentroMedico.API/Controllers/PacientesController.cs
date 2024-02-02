using CentroMedico.BL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CentroMedico.BL.Services.Implements;
using CentroMedico.BL.Repositories.Implements;
using AutoMapper;
using System.Threading.Tasks;
using CentroMedico.BL.DTOs;
using CentroMedico.BL.Models;

namespace CentroMedico.API.Controllers
{
    public class PacientesController : ApiController
    {
        private IMapper mapper;
        private readonly PacienteService pacienteService = new PacienteService(new PacienteRepository(CentroMedicoContext.Create()));

        public PacientesController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var courses = await pacienteService.GetAll();
            var coursesDTO = courses.Select(x => mapper.Map<PacienteDTO>(x));

            return Ok(coursesDTO);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var course = await pacienteService.GetById(id);

            if (course == null)
            {
                return NotFound();
            }

            var courseDTO = mapper.Map<PacienteDTO>(course);

            return Ok(courseDTO);
        }

        [HttpPost]
        public async Task<IHttpActionResult> Insert(PacienteDTO courseDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var course = mapper.Map<Paciente>(courseDTO);
                course = await pacienteService.Insert(course);
                return Ok(course);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public async Task<IHttpActionResult> Update(PacienteDTO pacienteDTO, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (pacienteDTO.PacienteID != id)
            {
                return BadRequest();
            }

            var flag = await pacienteService.GetById(id);

            if (flag == null)
            {
                return NotFound();
            }

            try
            {
                var course = mapper.Map<Paciente>(pacienteDTO);
                course = await pacienteService.Update(course);
                return Ok(course);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        [HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {

            var flag = await pacienteService.GetById(id);

            if (flag == null)
            {
                return NotFound();
            }

            try
            {
                await pacienteService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return Ok();
        }
    }
}
