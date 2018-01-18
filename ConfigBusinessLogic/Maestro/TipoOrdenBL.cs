using ConfigBusinessEntity;
using ConfigDataAccess.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Maestro
{
    public class TipoOrdenBL
    {
        public int InsertarTipoOrden(MSTt03_tipo_orden obj)
        {
            return new TipoOrdenDA().InsertarTipoOrden(obj);
        }

        public void EliminarTipoOrden(int id)
        {
            new TipoOrdenDA().EliminarTipoOrden(id);
        }

        public void ActualizarTipoOrden(MSTt03_tipo_orden obj)
        {
            new TipoOrdenDA().ActualizarTipoOrden(obj);
        }

        public MSTt03_tipo_orden TipoOrdenXId(int id)
        {
            return new TipoOrdenDA().TipoOrdenXId(id);
        }

        public MSTt03_tipo_orden TipoOrdenXCod(string cod)
        {
            return new TipoOrdenDA().TipoOrdenXCod(cod);
        }

        public List<MSTt03_tipo_orden> ListaTipoOrden(int? id_estado = null, bool ocultarBlankReg = false)
        {
            var lista = new TipoOrdenDA().ListaTipoOrden(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                lista.RemoveAll(x => x.cod_tipo_orden == Parameter.BlankRegister);
            }

            return lista;
        }
    }
}
