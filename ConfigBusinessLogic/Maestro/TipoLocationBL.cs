using ConfigBusinessEntity;
using ConfigDataAccess.Maestro;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Maestro
{
    public class TipoLocationBL
    {
        public int InsertarTipoLocation(MSTt09_tipo_location obj)
        {
            return new TipoLocationDA().InsertarTipoLocation(obj);
        }

        public void EliminarTipoLocation(int id)
        {
            new TipoLocationDA().EliminarTipoLocation(id);
        }

        public void ActualizarTipoLocation(MSTt09_tipo_location obj)
        {
            new TipoLocationDA().ActualizarTipoLocation(obj);
        }

        public MSTt09_tipo_location TipoLocationXId(int id)
        {
            return new TipoLocationDA().TipoLocationXId(id);
        }

        public MSTt09_tipo_location TipoLocationXCod(string cod)
        {
            return new TipoLocationDA().TipoLocationXCod(cod);
        }

        public List<MSTt09_tipo_location> ListaTipoLocation(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new TipoLocationDA().ListaTipoLocation(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                var itemToRemove = lista.SingleOrDefault(x => x.cod_tipo_location == Parameter.BlankRegister);
                if (itemToRemove != null && itemToRemove.id_tipo_location > 0)
                    lista.Remove(itemToRemove);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_tipo_location != TopList.TipoLocation).ThenBy(x => x.txt_desc).ToList();

            return lista;
        }
    }
}
