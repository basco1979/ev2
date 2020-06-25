using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PremiosRepositorio : IPremiosRepositorio
    {
        public EV2_PW3Entities Contexto { get; set; }

        public PremiosRepositorio(EV2_PW3Entities ctx)
        {
            Contexto = ctx;
        }

        public void AltaPremios(CantidadPremiosPorCompetidor premio)
        {
            var pr = new CantidadPremiosPorCompetidor();
            pr.idCompetidor = premio.idCompetidor;
            

                Contexto.CantidadPremiosPorCompetidor.Add(premio);
                Contexto.SaveChanges();
        }

        public List<CantidadPremiosPorCompetidor> ObtenerTodos()
        {
            return Contexto.CantidadPremiosPorCompetidor.ToList();
        }

        public List<Competidor> ObtenerTodosLosCompetidores()
        {
            return Contexto.Competidor.ToList();
        }

    }
}
