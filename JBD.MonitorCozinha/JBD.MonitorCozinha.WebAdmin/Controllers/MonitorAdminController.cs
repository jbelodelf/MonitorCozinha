using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using JBD.MonitorCozinha.Domain.Enuns;
using JBD.MonitorCozinha.WebAdmin.Models;
using JBD.MonitorCozinha.WebAdmin.Services;
using Microsoft.AspNetCore.Mvc;

namespace JBD.MonitorCozinha.WebAdmin.Controllers
{
    public class MonitorAdminController : Controller
    {
        private readonly IMapper _mapper;
        private readonly MonitorAdminServiceWeb _monitorAdminServiceWeb;

        public MonitorAdminController(IMapper mapper)
        {
            _mapper = mapper;
            _monitorAdminServiceWeb = new MonitorAdminServiceWeb(_mapper);
        }

        // GET: Monitor
        public ActionResult Index()
        {
            if (!Controle.ValidarUsuarioLogado()){ return RedirectToAction("Index", "Login"); }

            List<NumeroPedidoViewModel> numeroPedidoViewModel = new List<NumeroPedidoViewModel>();
            NumeroPedidoViewModel numeroPedidoVM = new NumeroPedidoViewModel();
            var numeroPedidoDTO = _monitorAdminServiceWeb.ListarNumeroPedidos();

            numeroPedidoViewModel = _mapper.Map<List<NumeroPedidoViewModel>>(numeroPedidoDTO);
            return View(numeroPedidoViewModel.OrderBy(n => n.IdNumeroPedido));
        }

        // GET: MonitorAdmin/AtualizaStatus/1/5
        public ActionResult AlterarNumeroPedido(int IdNumeroPedido, StatusPedidoEnum Idstatus)
        {
            if (!Controle.ValidarUsuarioLogado()) { return RedirectToAction("Index", "Login"); }

            NumeroPedidoViewModel numeroPedidoVM = _monitorAdminServiceWeb.ObterNumeroPedido(IdNumeroPedido);
            numeroPedidoVM.IdStatusPedido = Idstatus;
            _monitorAdminServiceWeb.AlterarNumeroPedido(numeroPedidoVM);
            bool retorno = true;

            return Json(new { resultado = retorno });
        }

        // POST: MonitorAdmin/InserirNumeroPedido/
        [HttpPost]
        public ActionResult InserirNumeroPedido(int IdEmpresa, int IdUnidade, string NumeroPedido)
        {
            if (!Controle.ValidarUsuarioLogado()) { return RedirectToAction("Index", "Login"); }

            NumeroPedidoViewModel numeroPedidoVM = new NumeroPedidoViewModel() {
                IdEmpresa = IdEmpresa,
                IdUnidade = IdUnidade,
                NumeroPedido = NumeroPedido,
                IdStatusPedido = StatusPedidoEnum.AFazer,
                DataCadastro = DateTime.Now
            };
            _monitorAdminServiceWeb.CadastrarNumeroPedido(numeroPedidoVM);
            bool retorno = true;

            return Json(new { resultado = retorno });
        }

        // GET: MonitorAdmin/DeletarNumeroPedido/1/5
        public ActionResult DeletarNumeroPedido(int IdNumeroPedido)
        {
            if (!Controle.ValidarUsuarioLogado()) { return RedirectToAction("Index", "Login"); }

            bool retorno = _monitorAdminServiceWeb.DeletarNumeroPedido(IdNumeroPedido);
            return Json(new { resultado = retorno });
        }
    }
}