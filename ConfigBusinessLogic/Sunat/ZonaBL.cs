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
    public class ZonaBL
    {
        public List<SNTt16_zona> ListaZona(int? id_estado = null, bool enableTopList = false)
        {
            var list = new ZonaDA().ListaZona(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_zona != TopList.Zona).ThenBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
