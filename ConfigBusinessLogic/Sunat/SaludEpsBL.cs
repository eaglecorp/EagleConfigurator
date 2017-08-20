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
    public class SaludEpsBL
    {
        public List<SNTt23_salud_eps> ListaSaludEps(int? id_estado = null, bool enableTopList = false)
        {
            var list = new SaludEpsDA().ListaSaludEps(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_salud_eps != TopList.SaludEPS).ThenBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
