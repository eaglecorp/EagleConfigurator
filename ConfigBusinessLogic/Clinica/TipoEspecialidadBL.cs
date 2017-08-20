using ConfigBusinessEntity;
using ConfigDataAccess.Clinica;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Clinica
{
    public class TipoEspecialidadBL
    {
        public List<CLIt06_tipo_especialidad> ListaTipoEspecialidad(int? id_estado = null, bool enableTopList = false)
        {
            var list =  new TipoEspecialidadDA().ListaTipoEspecialidad(id_estado);

            if (enableTopList && list != null)
                return list.OrderBy(x => x.cod_tipo_especialidad != TopList.TipoEspcMedica).ThenBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
