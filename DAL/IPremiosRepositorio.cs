using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IPremiosRepositorio
    {
        void AltaPremios(CantidadPremiosPorCompetidor premio);
        List<CantidadPremiosPorCompetidor> ObtenerTodos();

        List<Competidor> ObtenerTodosLosCompetidores();
    }
}
