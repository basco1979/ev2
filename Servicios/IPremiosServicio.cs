using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Servicios
{
    public interface IPremiosServicio
    {
        void AltaPremios(CantidadPremiosPorCompetidor premio);

        List<CantidadPremiosPorCompetidor> ObtenerTodos();
        List<Competidor> ObtenerTodosLosCompetidores();
    }
}
