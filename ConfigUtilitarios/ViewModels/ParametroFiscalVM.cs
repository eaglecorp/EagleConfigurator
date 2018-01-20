using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilitarios.ViewModels
{
    public class ParametroFiscalVM
    {
        public int id_parametro_fiscal { get; set; }
        public string cod_parametro_fiscal { get; set; }
        public string txt_desc { get; set; }
        public string valor_default { get; set; }
    }
}
