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
    public class RegimenPensionarioBL
    {
        public List<SNTt20_regimen_pensionario> ListaRegimenPensionario(int? id_estado = null, bool enableTopList = false)
        {
            var list = new RegimenPensionarioDA().ListaRegimenPensionario(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_regimen_pensionario != TopList.RegPensionario).ThenBy(x => x.txt_abrv).ToList();

            return list;
        }
    }
}
