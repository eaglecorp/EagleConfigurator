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
    public class OcupacionBL
    {
        public List<SNTt19_ocupacion> ListaOcupacion(int? id_estado = null, bool enableTopList = false)
        {
            var list =  new OcupacionDA().ListaOcupacion(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_ocupacion != TopList.Ocupacion).ThenBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
