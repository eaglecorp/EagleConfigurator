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
    public class EntidadFinancieraBL
    {
        public List<SNTt03_entidad_financiera> ListaEntidadFinanciera(int? id_estado = null, bool enableTopList = false)
        {
            var list = new EntidadFinancieraDA().ListaEntidadFinanciera(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_entidad_financiera != TopList.EntidadFinanciera).ThenBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
