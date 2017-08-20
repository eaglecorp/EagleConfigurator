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
    public class DepartamentoBL
    {
        public List<SNTt31_departamento> ListaDepartamento(int? id_estado = null, bool enableTopList = false)
        {
            var list = new DepartamentoDA().ListaDepartamento(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_dpto != TopList.Departamento).ThenBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
