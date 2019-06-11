using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JBD.MonitorCozinha.Application.Interfaces;
using JBD.MonitorCozinha.WebAdmin.Models;
using JBD.MonitorCozinha.WebAdmin.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JBD.MonitorCozinha.WebAdmin.Controllers
{
    public class MonitorController : Controller
    {
        private readonly IMapper _mapper;

        public MonitorController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET: Monitor
        public ActionResult Index()
        {
            MonitorServiceWeb monitorServiceWeb = new MonitorServiceWeb(_mapper);

            List<NumeroPedidoViewModel> numeroPedidoViewModel = new List<NumeroPedidoViewModel>();
            NumeroPedidoViewModel numeroPedidoVM = new NumeroPedidoViewModel();
            var numeroPedidoDTO = monitorServiceWeb.ListarNumeroPedidos();

            numeroPedidoViewModel = _mapper.Map<List<NumeroPedidoViewModel>>(numeroPedidoDTO);

            return View(numeroPedidoViewModel.OrderBy(n => n.IdNumeroPedido));
        }

        // GET: Monitor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Monitor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Monitor/Create
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

        // GET: Monitor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Monitor/Edit/5
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

        // GET: Monitor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Monitor/Delete/5
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