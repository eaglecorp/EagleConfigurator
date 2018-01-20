using ConfigBusinessEntity;
using ConfigDataAccess.Fiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Fiscal
{
    public class ParametroFiscalBL
    {
        public List<FISt04_parametro_fiscal> ListaParametroFiscal()
        {
            return new ParametroFiscalDA().ListaParametroFiscal();
        }

        public bool ActualizarParametrosFiscales(List<FISt04_parametro_fiscal> parametrosFiscales)
        {
            return new ParametroFiscalDA().ActualizarParametrosFiscales(parametrosFiscales);
        }
    }
}
