using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Partials
{
    class CompetidorMetadataType
    {
        public int id { get; set; }

       [Required(ErrorMessage = "Debe completar el nombre")]
       [StringLength(100,ErrorMessage = "Maximo 100 caracteres")]
        public string Nombre { get; set; }
    }
}
