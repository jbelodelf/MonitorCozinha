using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JBD.MonitorCozinha.WebAdmin.Models;
using JBD.MonitorCozinha.WebAdmin.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JBD.MonitorCozinha.WebAdmin.Controllers
{
    public class UnidadeController : Controller
    {

        private readonly IMapper _mapper;

        public UnidadeController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET: Unidade
        public ActionResult Index()
        {
            UnidadeServiceWeb unidadeServiceWeb = new UnidadeServiceWeb(_mapper);
            EmpresaServiceWeb empresaServiceWeb = new EmpresaServiceWeb(_mapper);


            var vm = new UnidadeViewModel();
            var empresas = empresaServiceWeb.ListarEmpresas();



            if (empresas.Any())
            {               
               vm.Empresas = empresas.Select(c => new EmpresaViewModel { IdEmpresa = c.IdEmpresa, NomeFantasia = c.NomeFantasia });
                
            }

            return View(vm);
        }

        public ActionResult ListarUnidades(string nomeUnidade)
        {
            UnidadeServiceWeb unidadeServiceWeb = new UnidadeServiceWeb(_mapper);
            EmpresaServiceWeb empresaServiceWeb = new EmpresaServiceWeb(_mapper);

            List<UnidadeViewModel> unidadesViewModel = new List<UnidadeViewModel>();
            var unidadesDTO = unidadeServiceWeb.ListarUnidades();

            
            unidadesViewModel = _mapper.Map<List<UnidadeViewModel>>(unidadesDTO);


            return PartialView("~/Views/Unidade/_listarUnidades.cshtml", unidadesViewModel);
        }


        // GET: Unidade/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Unidade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Unidade/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult SalvarUnidade(UnidadeViewModel unidade)
        {
            try
            {
                UnidadeServiceWeb unidadeServiceWeb = new UnidadeServiceWeb(_mapper);
                unidadeServiceWeb.CadastrarUnidade(unidade);

                return Json (new {mensagem = "Registro salvo com sucesso", retorno = "200" });
            }
            catch
            {
                return View();
            }
        }

        // GET: Unidade/Edit/5
        public ActionResult EditarUnidade(int id)
        {

            UnidadeServiceWeb unidadeServiceWeb = new UnidadeServiceWeb(_mapper);
            UnidadeViewModel unidadeVM = new UnidadeViewModel();

            unidadeVM = unidadeServiceWeb.ObterUnidade(id);


            return Json(new { retorno = 200, data = unidadeVM });
        }

        // POST: Unidade/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult EditarUnidade(int id, IFormCollection collection)
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

        // GET: Unidade/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Unidade/Delete/5
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