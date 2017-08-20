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
    public class RegimenSaludBL
    {
        public List<SNTt29_regimen_salud> ListaRegimenSalud(int? id_estado = null, bool enableTopList = false)
        {
            var list =  new RegimenSaludDA().ListaRegimenSalud(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_regimen_salud != TopList.RegSalud).ThenBy(x => x.txt_abrv).ToList();

            return list;
        }
    }
}
