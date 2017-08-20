using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using ConfigDataAccess;
using ConfigUtilitarios;

namespace ConfigBusinessLogic
{
    public class TipoMonedaBL
    {
        public List<SNTt04_tipo_moneda> ListaTipoMoneda(int? id_estado, bool enableTopList = false)
        {
            var list = new TipoMonedaDA().ListaTipoMoneda(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_tipo_moneda != TopList.TipoMoneda).ThenBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
