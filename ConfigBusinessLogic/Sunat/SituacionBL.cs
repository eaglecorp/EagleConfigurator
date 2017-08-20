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
    public class SituacionBL
    {
        public List<SNTt24_situacion> ListaSituacion(int? id_estado = null, bool enableTopList = false)
        {
            var list = new SituacionDA().ListaSituacion(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_situacion != TopList.Situacion).ThenBy(x => x.txt_abrv).ToList();

            return list;
        }
    }
}
