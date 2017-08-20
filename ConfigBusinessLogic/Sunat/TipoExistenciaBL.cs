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
    public class TipoExistenciaBL
    {
        public List<SNTt05_tipo_existencia> ListaTipoExistencia(int? id_estado, bool enableTopList = false)
        {
            var list =  new TipoExistenciaDA().ListaTipoExistencia(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_tipo_existencia != TopList.TipoExistencia).ThenBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
