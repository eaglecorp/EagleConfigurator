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
    public class RegimenLaboralBL
    {
        public List<SNTt30_regimen_laboral> ListaRegimenLaboral(int? id_estado = null, bool enableTopList = false)
        {
            var list = new RegimenLaboralDA().ListaRegimenLaboral(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_regimen_laboral != TopList.RegLaboral).ThenBy(x => x.txt_abrv).ToList();

            return list;
        }
    }
}
