using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using JBD.MonitorCozinha.WebAdmin.Models;
using JBD.MonitorCozinha.WebAdmin.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace JBD.MonitorCozinha.WebAdmin.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IMapper _mapper;
        EmpresaServiceWeb _empresaServiceWeb;

        public EmpresaController(IMapper mapper)
        {
            _mapper = mapper;
            _empresaServiceWeb = new EmpresaServiceWeb(_mapper);
        }

        // GET: Empresa
        public ActionResult Index()
        {
            if (!Controle.ValidarUsuarioLogado()) { return RedirectToAction("Index", "Login"); }
            return View();
        }

        // GET: Empresa
        public ActionResult ListarEmpresas(string nomeEmpresa)
        {
            if (!Controle.ValidarUsuarioLogado()) { return RedirectToAction("Index", "Login"); }

            if (nomeEmpresa != null)
            {
                var empresaDTO = _empresaServiceWeb.ListarEmpresas().Where(c => c.NomeFantasia.ToUpper().Contains(nomeEmpresa.Trim().ToUpper())).ToList();
                List<EmpresaViewModel> empresaVM = new List<EmpresaViewModel>();
                empresaVM = _mapper.Map<List<EmpresaViewModel>>(empresaDTO);
                return PartialView("~/Views/Empresa/_listarEmpresas.cshtml", empresaVM);
            }
            else
            {

                List<EmpresaViewModel> empresasViewModel = new List<EmpresaViewModel>();
                EmpresaViewModel empresaVM = new EmpresaViewModel();
                var empresasDTO = _empresaServiceWeb.ListarEmpresas();
                empresasViewModel = _mapper.Map<List<EmpresaViewModel>>(empresasDTO);
                return PartialView("~/Views/Empresa/_listarEmpresas.cshtml", empresasViewModel);
            }
        }

        // GET: Empresa
        public ActionResult ObterUnidadesByEmpresa(int IdEmpresa)
        {
            if (!Controle.ValidarUsuarioLogado()) { return RedirectToAction("Index", "Login"); }

            EmpresaViewModel empresasViewModel = new EmpresaViewModel();
            //EmpresaViewModel empresaVM = new EmpresaViewModel();
            var empresasDTO = _empresaServiceWeb.ObterEmpresa(IdEmpresa);
            empresasViewModel = _mapper.Map<EmpresaViewModel>(empresasDTO);
            return PartialView("~/Views/Unidade/_listarUnidades.cshtml", empresasViewModel);
        }

        // GET: Empresa/Details/5
        public ActionResult Details(int id)
        {
            if (!Controle.ValidarUsuarioLogado()) { return RedirectToAction("Index", "Login"); }

            return View();
        }

        // POST: Empresa/Create
        [HttpPost]
        public ActionResult SalvarEmpresa(EmpresaViewModel empresa)
        {
            if (!Controle.ValidarUsuarioLogado()) { return RedirectToAction("Index", "Login"); }

            try
            {
                EmpresaViewModel empresaViewModel = new EmpresaViewModel();
                _empresaServiceWeb.CadastrarEmpresa(empresa);
                return Json ( new { mensagem = "Registro salvo com sucesso", retorno = "200"});
            }
            catch
            {
                return View();
            }
        }

        // GET: Empresa/Edit/5
        public ActionResult EditarEmpresa(int id)
        {
            if (!Controle.ValidarUsuarioLogado()) { return RedirectToAction("Index", "Login"); }

            EmpresaViewModel empresaVM = new EmpresaViewModel();
            empresaVM = _empresaServiceWeb.ObterEmpresa(id);
            return Json(new {retorno = 200, data = empresaVM});
        }

        // POST: Empresa/Edit/5
        [HttpPost]
        public ActionResult EditarEmpresa(int id, EmpresaViewModel empresa)
        {
            if (!Controle.ValidarUsuarioLogado()) { return RedirectToAction("Index", "Login"); }

            try
            {
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Empresa/Delete/5
        public ActionResult Delete(int id)
        {
            if (!Controle.ValidarUsuarioLogado()) { return RedirectToAction("Index", "Login"); }

            return View();
        }

        // POST: Empresa/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            if (!Controle.ValidarUsuarioLogado()) { return RedirectToAction("Index", "Login"); }

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