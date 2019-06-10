using AutoMapper;
using JBD.MonitorCozinha.Domain.DTOS;
using JBD.MonitorCozinha.WebAdmin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace JBD.MonitorCozinha.WebAdmin.Services
{
    public class EmpresaServiceWeb
    {
        private readonly IMapper _mapper;

        public EmpresaServiceWeb(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<EmpresaViewModel> ListarEmpresas()
        {
            using (HttpClient client = new HttpClient())
            {
                ServiceBase(client);
                HttpResponseMessage response = client.GetAsync("ListarEmpresas").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                List<EmpresaDTO> data = JsonConvert.DeserializeObject<List<EmpresaDTO>>(stringData);

                var empresasModel = _mapper.Map<List<EmpresaViewModel>>(data);
                return empresasModel;
            }
        }

        public void ServiceBase(HttpClient client)
        {
            client.BaseAddress = new Uri("http://localhost:52936/api/Empresa/");
            MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
        }

    }
}
