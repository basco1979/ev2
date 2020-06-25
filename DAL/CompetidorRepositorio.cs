using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
        public class CompetidorRepositorio : ICompetidorRepositorio
    {
            public EV2_PW3Entities Contexto { get; set; }

            public CompetidorRepositorio(EV2_PW3Entities ctx)
            {
                Contexto = ctx;
            }

            public void AltaCompetidor(Competidor competidor)
            {
           
                Contexto.Competidor.Add(competidor);
                Contexto.SaveChanges();
            }
            

            public List<Competidor> ObtenerTodos()
            {
                return Contexto.Competidor.ToList();
            }

    }
}
