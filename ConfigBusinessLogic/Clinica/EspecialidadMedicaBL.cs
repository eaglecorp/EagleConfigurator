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
    public class EspecialidadMedicaBL
    {
        public List<CLIt07_especialidad_medica> ListaEspcMedicaXTipo(int id_tipo_especialidad, int? id_estado = null)
        {
            var list = new EspecialidadMedicaDA().ListaEspcMedicaXTipo(id_tipo_especialidad, id_estado);

            if (list != null)
                return list.OrderBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
