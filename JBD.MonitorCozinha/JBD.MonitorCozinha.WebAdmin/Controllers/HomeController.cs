using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JBD.MonitorCozinha.WebAdmin.Models;
using JBD.MonitorCozinha.Application.Interfaces;

namespace JBD.MonitorCozinha.WebAdmin.Controllers
{
    public class HomeController : Controller
    {
        IEmpresaApp _empresaApp;

        public HomeController(IEmpresaApp empresaApp)
        {
            _empresaApp = empresaApp;
        }

        public IActionResult Index()
        {
            var listaEmpresa = _empresaApp.ListarEmpresas();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
