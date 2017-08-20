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
    public class UnidadMedidaBL
    {
        public List<SNTt06_unidad_medida> ListaUnidadMed(int? id_estado, bool enableTopList = false)
        {
            var list =  new UnidadMedidaDA().ListaUnidadMed(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_um != TopList.UnidadMedida).ThenBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
