using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Servicios
{
    public interface ICompetidorServicio
    {
        void AltaCompetidor(Competidor competidor);

        List<Competidor> ObtenerTodos();
    }
}
