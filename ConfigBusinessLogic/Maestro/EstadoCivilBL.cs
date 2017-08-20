using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using ConfigDataAccess.Maestro;
using ConfigUtilitarios;

namespace ConfigBusinessLogic.Maestro
{
    public class EstadoCivilBL
    {
        public List<MSTt07_estado_civil> ListaEstadoCivil(int? id_estado=null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new EstadoCivilDA().ListaEstadoCivil(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                var itemToRemove = lista.SingleOrDefault(x => x.cod_estado_civil == Parameter.BlankRegister);
                if (itemToRemove != null && itemToRemove.id_estado_civil > 0)
                    lista.Remove(itemToRemove);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_estado_civil != TopList.EstadoCivil).ThenBy(x => x.txt_desc).ToList();

            return lista;
        }
    }
}
