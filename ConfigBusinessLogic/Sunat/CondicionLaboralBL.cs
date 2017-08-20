using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using ConfigDataAccess.Sunat;
using ConfigUtilitarios;

namespace ConfigBusinessLogic.Sunat
{
    public class CondicionLaboralBL
    {
        public List<SNTt21_condicion_laboral> ListaCondicionLaboral(int? id_estado=null, bool enableTopList = false)
        {
            var list =  new CondicionLaboralDA().ListaCondicionLaboral(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_condicion_laboral != TopList.CondicionLaboral).ThenBy(x => x.txt_abrv).ToList();

            return list;
        }
    }
}
