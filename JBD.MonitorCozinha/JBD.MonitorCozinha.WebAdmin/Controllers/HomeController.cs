using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JBD.MonitorCozinha.WebAdmin.Models;
using JBD.MonitorCozinha.Application.Interfaces;
using AutoMapper;
using JBD.MonitorCozinha.WebAdmin.Services;

namespace JBD.MonitorCozinha.WebAdmin.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IEmpresaApp _empresaApp;
        //private readonly IMapper _mapper;

        //public HomeController(IEmpresaApp empresaApp, IMapper mapper)
        //{
        //    _empresaApp = empresaApp;
        //    _mapper = mapper;
        //}

        public IActionResult Index()
        {
            //EmpresaServiceWeb service = new EmpresaServiceWeb(_mapper);
            //var teste = service.ListarEmpresas();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
