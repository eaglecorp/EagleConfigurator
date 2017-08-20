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
    public class NacionalidadBL
    {
        public List<SNTt14_nacionalidad> ListaNacionalidad(int? id_estado = null, bool enableTopList = false)
        {
            var list = new NacionalidadDA().ListaNacionalidad(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_nacionalidad != TopList.Nacionalidad).ThenBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
