using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilitarios.ViewModels
{
    public class ParametroFiscalDeCajaVM
    {
        public int id { get; set; }
        public int id_caja { get; set; }
        public int id_parametro_fiscal { get; set; }
        public string cod { get; set; }
        public string parametro { get; set; }
        public string valor { get; set; }
    }
}
