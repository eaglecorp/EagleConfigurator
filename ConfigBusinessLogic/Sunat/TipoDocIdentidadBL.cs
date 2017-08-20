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
    public class TipoDocIdentidadBL
    {
        public List<SNTt02_tipo_doc_identidad> ListaTipoDocIdentidad(int? id_estado = null, bool enableTopList = false)
        {
            var list = new TipoDocIdentidadDA().ListaTipoDocIdentidad(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_tipo_doc_identidad != TopList.TipoDocIdentidad).ThenBy(x => x.txt_abrv).ToList();

            return list;
        }
    }
}
