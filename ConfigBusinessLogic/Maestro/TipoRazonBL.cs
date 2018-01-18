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
    public class TipoRazonBL
    {
        public int InsertarTipoRazon(MSTt16_tipo_razon obj)
        {
            return new TipoRazonDA().InsertarTipoRazon(obj);
        }

        public void EliminarTipoRazon(int id)
        {
            new TipoRazonDA().EliminarTipoRazon(id);
        }

        public void ActualizarTipoRazon(MSTt16_tipo_razon obj)
        {
            new TipoRazonDA().ActualizarTipoRazon(obj);
        }
  
        public MSTt16_tipo_razon TipoRazonXId(int id)
        {
            return new TipoRazonDA().TipoRazonXId(id);
        }

        public MSTt16_tipo_razon TipoRazonXCod(string cod)
        {
            return new TipoRazonDA().TipoRazonXCod(cod);
        }

        public List<MSTt16_tipo_razon> ListaTipoRazon(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new TipoRazonDA().ListaTipoRazon(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                lista.RemoveAll(x => x.cod_tipo_razon == Parameter.BlankRegister);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_tipo_razon != TopList.TipoRazon).ThenBy(x => x.txt_desc).ToList();

            return lista;
        }
    }
}
