using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using JBD.MonitorCozinha.WebAdmin.Models;
using JBD.MonitorCozinha.WebAdmin.Services;
using Microsoft.AspNetCore.Mvc;

namespace JBD.MonitorCozinha.WebAdmin.Controllers
{
    public class MonitorController : Controller
    {
        private readonly IMapper _mapper;
        private readonly MonitorServiceWeb _monitorServiceWeb;

        public MonitorController(IMapper mapper)
        {
            _mapper = mapper;
            _monitorServiceWeb = new MonitorServiceWeb(_mapper);
        }

        // GET: Monitor
        public ActionResult Index()
        {
            if (!Controle.ValidarUsuarioLogado()) { return RedirectToAction("Index", "Login"); }

            List<NumeroPedidoViewModel> numeroPedidoViewModel = new List<NumeroPedidoViewModel>();
            NumeroPedidoViewModel numeroPedidoVM = new NumeroPedidoViewModel();
            var numeroPedidoDTO = _monitorServiceWeb.ListarNumeroPedidos();
            numeroPedidoViewModel = _mapper.Map<List<NumeroPedidoViewModel>>(numeroPedidoDTO);
            return View(numeroPedidoViewModel.OrderBy(n => n.IdNumeroPedido));
        }
    }
}