﻿using AutoMapper;
using JBD.MonitorCozinha.Domain.DTOS;
using JBD.MonitorCozinha.WebAdmin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace JBD.MonitorCozinha.WebAdmin.Services
{
    public class MonitorServiceWeb
    {
        private readonly IMapper _mapper;

        public MonitorServiceWeb(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<NumeroPedidoViewModel> ListarNumeroPedidos()
        {
            using (HttpClient client = new HttpClient())
            {
                ServiceBase(client);
                HttpResponseMessage response = client.GetAsync("ListarNumeroPedidos").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                List<NumeroPedidoDTO> data = JsonConvert.DeserializeObject<List<NumeroPedidoDTO>>(stringData);

                var numeroPedidoModel = _mapper.Map<List<NumeroPedidoViewModel>>(data);
                return numeroPedidoModel;
            }
        }

        public void ServiceBase(HttpClient client)
        {
            client.BaseAddress = new Uri("http://localhost:52936/api/Monitor/");
            MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
        }

    }
}
