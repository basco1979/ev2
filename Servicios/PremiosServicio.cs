using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Servicios
{
    public class PremiosServicio : IPremiosServicio
    {
        protected IPremiosRepositorio PremiosRepositorio { get; set; }

        public PremiosServicio(EV2_PW3Entities ctx)
        {
            PremiosRepositorio = new PremiosRepositorio(ctx);
        }
        public void AltaPremios(CantidadPremiosPorCompetidor premio)
        {
            PremiosRepositorio.AltaPremios(premio);
        }

        public List<CantidadPremiosPorCompetidor> ObtenerTodos()
        {
            return PremiosRepositorio.ObtenerTodos();
        }

        public List<Competidor> ObtenerTodosLosCompetidores()
        {
            return PremiosRepositorio.ObtenerTodosLosCompetidores();
        }
    }
}
