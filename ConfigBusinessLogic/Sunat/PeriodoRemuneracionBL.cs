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
    public class PeriodoRemuneracionBL
    {
        public List<SNTt22_periodo_remuneracion> ListaPeriodoRemuneracion(int? id_estado = null, bool enableTopList = false)
        {
            var list = new PeriodoRemuneracionDA().ListaPeriodoRemuneracion(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_periodo_remuneracion != TopList.PeriodoRemuneracion).ThenBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
