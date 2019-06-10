using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using JBD.MonitorCozinha.Application.Interfaces;
using JBD.MonitorCozinha.Domain.DTOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JBD.MonitorCozinha.WebApiAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IMapper _mapper;
        IEmpresaApp _empresaApp;

        public EmpresaController(IMapper mapper, IEmpresaApp empresaApp)
        {
            _mapper = mapper;
            _empresaApp = empresaApp;
        }

        // GET api/values
        //[HttpGet("ListarEmpresas")]
        [AcceptVerbs("GET")]
        [Route("ListarEmpresas")]
        public ObjectResult ListarEmpresas()
        {
            var empresasEntity = _empresaApp.ListarEmpresas();
            var empresasDTO = _mapper.Map<List<EmpresaDTO>>(empresasEntity);
            return StatusCode((int)HttpStatusCode.OK, empresasDTO); 
        }

        // GET api/values
        //[HttpGet("{id}", Name = "ObterEmpresas")]
        [AcceptVerbs("GET")]
        [Route("ObterEmpresas/{id}")]
        public ObjectResult ObterEmpresas(int id)
        {
            var empresaEntity = _empresaApp.ObterEmpresaById(id);
            var empresaDTO = _mapper.Map<EmpresaDTO>(empresaEntity);
            return StatusCode((int)HttpStatusCode.OK, empresaDTO);
        }

        // POST: api/Empresa
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Empresa/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
