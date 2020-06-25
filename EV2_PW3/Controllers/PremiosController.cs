using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Servicios;

namespace EV2_PW3.Controllers
{
    public class PremiosController : Controller
    {
        IPremiosServicio PremiosServicio;

        public PremiosController()
        {
            EV2_PW3Entities ctx = new EV2_PW3Entities();
            PremiosServicio = new PremiosServicio(ctx);
        }
        // GET: Premios
        public ActionResult ListaPremios()
        {
            
            List<CantidadPremiosPorCompetidor> premio = PremiosServicio.ObtenerTodos();
            return View(premio);
        }

        [HttpGet]
        public ActionResult AltaPremios()
        {
            ViewBag.Todos = PremiosServicio.ObtenerTodosLosCompetidores();
            return View();
        }
        [HttpPost]
        public ActionResult AltaPremios(CantidadPremiosPorCompetidor premio)
        {
            if (ModelState.IsValid)
            {
                PremiosServicio.AltaPremios(premio);
                return RedirectToAction("ListaPremios");
            }
            else
            {
                ViewBag.IdCompetidor = premio.id;
                ViewBag.Todos = PremiosServicio.ObtenerTodosLosCompetidores();
                return View(premio);
            }
        }

    }
}
