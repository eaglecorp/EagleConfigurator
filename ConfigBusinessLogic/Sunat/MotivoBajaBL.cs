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
    public class MotivoBajaBL
    {
        public List<SNTt25_motivo_baja> ListaMotivoBaja(int? id_estado = null, bool enableTopList = false)
        {
            var list = new MotivoBajaDA().ListaMotivoBaja(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_motivo_baja != TopList.MotivoBaja).ThenBy(x => x.txt_abrv).ToList();

            return list;
        }
    }
}
