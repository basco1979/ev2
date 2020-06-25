using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Servicios;

namespace EV2_PW3.Controllers
{
    public class CompetidoresController : Controller
    {
        ICompetidorServicio CompetidorServicio;

        public CompetidoresController()
        {
            EV2_PW3Entities ctx = new EV2_PW3Entities();
            CompetidorServicio = new CompetidorServicio(ctx);
        }

        public ActionResult ListaCompetidores()
        {
            List<Competidor> competidor = CompetidorServicio.ObtenerTodos();
            return View(competidor);
        }
        [HttpGet]
        public ActionResult AltaCompetidor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AltaCompetidor(Competidor competidor)
        {
            if (ModelState.IsValid)
            {
                CompetidorServicio.AltaCompetidor(competidor);
                return RedirectToAction("ListaCompetidores");
            }
            else
            {
                return View(competidor);
            }
        }
        }
    }
