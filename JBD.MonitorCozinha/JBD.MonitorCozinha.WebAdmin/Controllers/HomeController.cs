﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JBD.MonitorCozinha.WebAdmin.Models;
using JBD.MonitorCozinha.WebAdmin.Services;
using AutoMapper;

namespace JBD.MonitorCozinha.WebAdmin.Controllers
{
    public class HomeController : Controller
    {
        EmpresaServiceWeb _service;
        private readonly IMapper _mapper;

        public HomeController(IMapper mapper)
        {
            _mapper = mapper;
            _service = new EmpresaServiceWeb(_mapper);
        }

        // GET: Index/funcionalidade
        //[HttpGet("Index/{funcionalidade}")]
        public ActionResult Index(string funcionalidade)
        {
            var empresa = _service.ObterEmpresa(Controle.ControleAcesso.IdEmpresa);
            Controle.PerfilPFuncionalidade.Nome = funcionalidade;

            var testeA = Controle.ControleAcesso;
            var testeF = Controle.PerfilPFuncionalidade;

            return View(empresa);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
