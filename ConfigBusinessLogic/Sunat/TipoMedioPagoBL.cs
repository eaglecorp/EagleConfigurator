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
    public class TipoMedioPagoBL
    {
        public List<SNTt01_tipo_medio_pago> ListaTipoMedioPago(int? id_estado = null, bool enableTopList = false)
        {
            var list =  new TipoMedioPagoDA().ListaTipoMedioPago(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_tipo_medio_pago != TopList.TipoMedioPago).ThenBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
