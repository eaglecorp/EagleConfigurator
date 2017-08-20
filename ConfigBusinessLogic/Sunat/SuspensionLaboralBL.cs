using ConfigBusinessEntity;
using ConfigDataAccess.Sunat;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Sunat
{
    public class SuspensionLaboralBL
    {
        public List<SNTt28_suspencion_laboral> ListaSuspencionLaboral(int? id_estado = null, bool enableTopList = false)
        {
            var list = new SuspencionLaboralDA().ListaSuspencionLaboral(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_suspencion_laboral != TopList.SuspencionLaboral).ThenBy(x => x.txt_abrv).ToList();

            return list;
        }
    }
}
