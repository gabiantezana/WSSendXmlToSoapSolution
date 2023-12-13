using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.QueryResults
{
    public class DescuentoDto
    {
        public string DOCNUM { get; set; }
        public string DESC_idconcepto { get; set; }
        public string DESC_escargo { get; set; }
        public string DESC_descripcion { get; set; }
        public string DESC_porcentaje { get; set; }
        public string DESC_base { get; set; }
        public string DESC_valor { get; set; }
    }
}
