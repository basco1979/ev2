using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace Servicios
{
    public class CompetidorServicio : ICompetidorServicio
    {
        protected ICompetidorRepositorio CompetidorRepositorio { get; set; }

        public CompetidorServicio(EV2_PW3Entities ctx)
        {
            CompetidorRepositorio = new CompetidorRepositorio(ctx);
        }
        public void AltaCompetidor(Competidor competidor)
        {
            CompetidorRepositorio.AltaCompetidor(competidor);
        }

        public List<Competidor> ObtenerTodos()
        {
            return CompetidorRepositorio.ObtenerTodos();
        }
    }
}
