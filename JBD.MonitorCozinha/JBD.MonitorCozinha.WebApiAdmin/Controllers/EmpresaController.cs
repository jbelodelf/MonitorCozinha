using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using JBD.MonitorCozinha.Application.Interfaces;
using JBD.MonitorCozinha.Domain.DTOS;
using JBD.MonitorCozinha.Domain.Entitys;
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
        public ObjectResult Get()
        {
            var empresasEntity = _empresaApp.ListarEmpresas();
            var empresasDTO = _mapper.Map<List<EmpresaDTO>>(empresasEntity);
            return StatusCode((int)HttpStatusCode.OK, empresasDTO); 
        }

        // GET api/values
        //[HttpGet("{id}", Name = "ObterEmpresas")]
        [AcceptVerbs("GET")]
        [Route("ObterEmpresa/{id}")]
        public ObjectResult Get(int id)
        {
            var empresaEntity = _empresaApp.ObterEmpresaById(id);
            var empresaDTO = _mapper.Map<EmpresaDTO>(empresaEntity);
            return StatusCode((int)HttpStatusCode.OK, empresaDTO);
        }

        // POST: api/Empresa
        //[HttpPost]
        [AcceptVerbs("POST")]
        [Route("InserirEmpresa")]
        public ObjectResult Post([FromBody] EmpresaDTO empresa)
        {
            var empresaEntity = _mapper.Map<EmpresaEntity>(empresa);
            _empresaApp.Salvar(empresaEntity);
            return StatusCode((int)HttpStatusCode.Created, empresa);
        }

        // PUT: api/Empresa/5
        //[HttpPut("{id}")]
        [AcceptVerbs("PUT")]
        [Route("AlterarEmpresa")]
        public ObjectResult Put([FromBody] EmpresaDTO empresa)
        {
            var empresaEntity = _mapper.Map<EmpresaEntity>(empresa);
            _empresaApp.Salvar(empresaEntity);
            return StatusCode((int)HttpStatusCode.Created, empresa);
        }

        // DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        [AcceptVerbs("DELETE")]
        [Route("AlterarEmpresa/{id}")]
        public ObjectResult Delete(int id)
        {
            _empresaApp.Deletar(id);
            return StatusCode((int)HttpStatusCode.Created, id);
        }

        [AcceptVerbs("GET")]
        [Route("GetVerificaDuplicidadeCPF/{cpfcnpj}")]
        public ObjectResult GetVerificaDuplicidadeCPF(string cpfcnpj)
        {
            bool retorno = _empresaApp.VeficaDuplicidadeCnpjCpf(cpfcnpj);
            return StatusCode((int)HttpStatusCode.OK, retorno);

        }

    }
}
