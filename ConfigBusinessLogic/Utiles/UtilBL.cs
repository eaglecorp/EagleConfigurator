using ConfigDataAccess.General;
using ConfigDataAccess.Utiles;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Utiles
{
    public class UtilBL
    {
        public bool ValidarDelete(long idPadre, int codValPadre)
        {
            return new UtilDA().ValidarDetele(idPadre, codValPadre);
        }

        public bool RunContext()
        {
            bool isSuccess = false;
            var paramRun = new ParametroDA().ParametroXCod(Parameter.BlankRegister);
            if (paramRun != null && paramRun.id_parametro > 0)
            {
                isSuccess = new UtilDA().RunContext(paramRun);
            }
            else
            {
                var log = new Log();
                log.ArchiveLog("Run Context BL: ", $"No existe el parámetro RunContext(primer contacto con el contexto de EF). COD:{Parameter.BlankRegister}");
            }

            return isSuccess;
        }
    }
}
