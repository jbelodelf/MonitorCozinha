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
            if (nomeEmpresa != null)
            {
                EmpresaServiceWeb empresaServiceWeb = new EmpresaServiceWeb(_mapper);
                var empresaDTO = empresaServiceWeb.ListarEmpresas().Where(c => c.NomeFantasia.ToUpper().Contains(nomeEmpresa.Trim().ToUpper())).ToList();

                List<EmpresaViewModel> empresaVM = new List<EmpresaViewModel>();

                empresaVM = _mapper.Map<List<EmpresaViewModel>>(empresaDTO);

                return PartialView("~/Views/Empresa/_listarEmpresas.cshtml", empresaVM);
            }
            else
            {

                EmpresaServiceWeb empresaServiceWeb = new EmpresaServiceWeb(_mapper);

                List<EmpresaViewModel> empresasViewModel = new List<EmpresaViewModel>();
                EmpresaViewModel empresaVM = new EmpresaViewModel();
                var empresasDTO = empresaServiceWeb.ListarEmpresas();

                empresasViewModel = _mapper.Map<List<EmpresaViewModel>>(empresasDTO);

                return PartialView("~/Views/Empresa/_listarEmpresas.cshtml", empresasViewModel);

            }

            return View();

            
        }


        // GET: Empresa
        public ActionResult ObterUnidadesByEmpresa(int IdEmpresa)
        {
            EmpresaServiceWeb empresaServiceWeb = new EmpresaServiceWeb(_mapper);

            EmpresaViewModel empresasViewModel = new EmpresaViewModel();
            //EmpresaViewModel empresaVM = new EmpresaViewModel();
            var empresasDTO = empresaServiceWeb.ObterEmpresa(IdEmpresa);
            empresasViewModel = _mapper.Map<EmpresaViewModel>(empresasDTO);

            return PartialView("~/Views/Unidade/_listarUnidades.cshtml", empresasViewModel);
        }

        // GET: Empresa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //// GET: Empresa/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: Empresa/Create
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult SalvarEmpresa(EmpresaViewModel empresa)
        {
            try
            {
                EmpresaServiceWeb empresaServiceWeb = new EmpresaServiceWeb(_mapper);
                EmpresaViewModel empresaViewModel = new EmpresaViewModel();
                empresaServiceWeb.CadastrarEmpresa(empresa);

                return Json ( new { mensagem = "Registro salvo com sucesso", retorno = "200"});

               //return Json(new { retorno = response.StatusCode, mensagem = mensagemResp }, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return View();
            }
        }

        // GET: Empresa/Edit/5
        public ActionResult EditarEmpresa(int id)
        {

            EmpresaServiceWeb empresaServiceWeb = new EmpresaServiceWeb(_mapper);
            EmpresaViewModel empresaVM = new EmpresaViewModel();

            empresaVM = empresaServiceWeb.ObterEmpresa(id);

            return Json(new {retorno = 200, data = empresaVM});
        }

        // POST: Empresa/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult EditarEmpresa(int id, EmpresaViewModel empresa)
        {
            try
            {
                //EmpresaServiceWeb empresaServiceWeb = new EmpresaServiceWeb(_mapper);
                //empresaServiceWeb.AlterarEmpresa(empresa);

                //return Json(new {mensagem = "Registro alterado com sucesso", retorno ="200" });
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

        public ActionResult VeficaDuplicidadeCnpjCpf(string cnpjcpf)
        {
            var mensagem = "";
            EmpresaServiceWeb empresaServiceWeb = new EmpresaServiceWeb(_mapper);
            bool retorno = empresaServiceWeb.VeficaDuplicidadeCnpjCpf(cnpjcpf);

            if (retorno)
            {
                mensagem = "CPF está cadastrado, por favor verifique";
            }
             

            return Json(new { retorno = 200, duplicado = retorno ,mensagem = mensagem });
        }

    }
}