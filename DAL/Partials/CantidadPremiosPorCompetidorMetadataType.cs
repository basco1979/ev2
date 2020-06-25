using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Partials
{
    class CantidadPremiosPorCompetidorMetadataType
    {
        [Required(ErrorMessage = "Debe completar la cantidad de premios")]
        [Range(2,49, ErrorMessage = " La Cantidad debe ser mayor a 1 y menor a 50")]
        public int CantidadPremios { get; set; }
        [Required(ErrorMessage = "Debe completar el año")]
        [Range(2011,2021, ErrorMessage = " El año debe ser mayor a 2010")]
        public int Año { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un competidor")]
        public int idCompetidor { get; set; }

        public virtual Competidor Competidor { get; set; }
    }
}
