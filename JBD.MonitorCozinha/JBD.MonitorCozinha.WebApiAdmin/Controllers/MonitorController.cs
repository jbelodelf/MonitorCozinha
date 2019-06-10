using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    public class MonitorController : ControllerBase
    {
        private readonly IMapper _mapper;
        INumeroPedidoApp _numeroPedidoApp;

        public MonitorController(IMapper mapper, INumeroPedidoApp numeroPedidoApp)
        {
            _mapper = mapper;
            _numeroPedidoApp = numeroPedidoApp;
        }

        // GET: api/Monitor
        [AcceptVerbs("GET")]
        [Route("ListarNumeroPedidos")]
        public ObjectResult Get()
        {
            var numeroPedidoEntity = _numeroPedidoApp.ListarPedidos();
            var numeroPedidoDTO = _mapper.Map<List<NumeroPedidoDTO>>(numeroPedidoEntity);
            return StatusCode((int)HttpStatusCode.OK, numeroPedidoDTO);
        }


        // GET: api/Monitor/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Monitor
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Monitor/5
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
