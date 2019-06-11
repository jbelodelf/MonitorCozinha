using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JBD.MonitorCozinha.WebAdmin.Models;
using JBD.MonitorCozinha.WebAdmin.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JBD.MonitorCozinha.WebAdmin.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IMapper _mapper;
        public EmpresaController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET: Empresa
        public ActionResult Index()
        {
            return View();
        }

        // GET: Empresa
        public ActionResult ListarEmpresas(string nomeEmpresa)
        {
            EmpresaServiceWeb empresaServiceWeb = new EmpresaServiceWeb(_mapper);

            List<EmpresaViewModel> empresasViewModel = new List<EmpresaViewModel>();
            EmpresaViewModel empresaVM = new EmpresaViewModel();
            var empresasDTO = empresaServiceWeb.ListarEmpresas();

            empresasViewModel = _mapper.Map<List<EmpresaViewModel>>(empresasDTO);

            return PartialView("~/Views/Empresa/_listarEmpresas.cshtml", empresasViewModel);
        }


        // GET: Empresa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Empresa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Empresa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Empresa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Empresa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empresa/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}