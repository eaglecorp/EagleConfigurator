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
    public class ModalidadFormativaBL
    {
        public List<SNTt26_modalidad_formativa> ListaModalidadFormativa(int? id_estado = null, bool enableTopList = false)
        {
            var list = new ModalidadFormativaDA().ListaModalidadFormativa(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_modalidad_formativa != TopList.ModalidadFormativa).ThenBy(x => x.txt_abrv).ToList();

            return list;
        }
    }
}
