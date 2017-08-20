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
    public class TipoTrabajadorBL
    {
        public List<SNTt17_tipo_trabajador> ListaTipoTrabajador(int? id_estado = null, bool enableTopList = false)
        {
            var list = new TipoTrabajadorDA().ListaTipoTrabajador(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_tipo_trabajador != TopList.TipoTrabajador).ThenBy(x => x.txt_abrv).ToList();

            return list;
        }
    }
}
